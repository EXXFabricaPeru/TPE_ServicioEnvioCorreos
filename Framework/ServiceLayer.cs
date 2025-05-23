using EXX_WinService.Core;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using EXX_WinService.Entities;

namespace EXX_WinService.Framework
{
    public static class ServiceLayer
    {
        public static string Login(CONF config)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                var client = new RestClient(config.Url);
                var request = new RestRequest("Login", Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddCookie("B1SESSION", string.Empty);
                //request.AddCookie("ROUTEID", ".node0");
                request.AddJsonBody(config.b1slLogin);
                var rsp = client.Execute(request);
                if (rsp.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    if (string.IsNullOrEmpty(rsp.Content))
                        throw new InvalidOperationException(config.BaseDeDatos + ": " + rsp.ErrorMessage);
                    else
                        throw new InvalidOperationException(config.BaseDeDatos + ": " + rsp.Content);
                }
                var loginResponse = JsonConvert.DeserializeObject<SLLoginResponse>(rsp.Content);
                return loginResponse.SessionId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Logout(CONF config)
        {
            try
            {
                if (!string.IsNullOrEmpty(config.SessionId))
                {
                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                    var client = new RestClient(config.Url);
                    var request = new RestRequest("Logout", Method.POST);
                    request.AddHeader("content-type", "application/json");
                    request.AddCookie("B1SESSION", config.SessionId);
                    //request.AddCookie("ROUTEID", ".node0");
                    request.AddParameter("application/json", null, ParameterType.RequestBody);
                    var response = client.Execute(request);
                    if (!response.IsSuccessful) throw new InvalidOperationException(response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<T> Find<T>(CONF config, params Tuple<string, string, string>[] prms) where T : class, new()
        {
        band:
            try
            {
                var @object = new T();
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                var client = new RestClient(config.Url);
                var request = new RestRequest(Globals.BuildURI(@object), Method.GET);
                request.AddHeader("content-type", "application/json");
                request.AddCookie("B1SESSION", config.SessionId);
                string filterQuery = Globals.BuildFilter(prms);
                if (!string.IsNullOrEmpty(filterQuery))
                    request.AddParameter("$filter", filterQuery, ParameterType.QueryString);
                var rsp = client.Execute(request);

                if (rsp.StatusCode == HttpStatusCode.NotFound) return null;
                if (rsp.StatusCode != HttpStatusCode.OK && rsp.StatusCode != System.Net.HttpStatusCode.Created)
                    throw new ApplicationException(rsp.Content);

                JObject responseContent = JObject.Parse(rsp.Content);
                JToken values = responseContent["value"];

                if (values == null)
                    throw new Exception($"Bad Service Layer response:{rsp.Content}");

                return values.ToObject<List<T>>();
            }
            catch (Exception ex)
            {
                if (ex.Message == "No se logró establecer conexión con Service Layer")
                    throw ex;

                if (ex.Message.Contains("Invalid session"))
                {
                    config.SessionId = Login(config);
                    goto band;
                }

                var findResponse = JsonConvert.DeserializeObject<SLErrorResponse>(ex.Message);
                throw new Exception(findResponse.Error.Message.value);
            }
        }

        public static T FindById<T>(CONF config, T @object) where T : class, new()
        {
        band:
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                var client = new RestClient(config.Url);
                var request = new RestRequest(Globals.BuildURI(@object), Method.GET);
                request.AddHeader("content-type", "application/json");
                request.AddCookie("B1SESSION", config.SessionId);
                var rsp = client.Execute(request);

                if (rsp.StatusCode == HttpStatusCode.NotFound) return null;
                if (rsp.StatusCode != HttpStatusCode.OK && rsp.StatusCode != System.Net.HttpStatusCode.Created)
                    throw new ApplicationException(rsp.Content);

                JObject responseContent = JObject.Parse(rsp.Content);

                var settings = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new DynamicConverter<T>() },
                    NullValueHandling = NullValueHandling.Ignore
                };
                return responseContent.ToObject<T>(JsonSerializer.Create(settings));
            }
            catch (Exception ex)
            {
                if (ex.Message == "No se logró establecer conexión con Service Layer")
                    throw ex;

                if (ex.Message.Contains("Invalid session"))
                {
                    config.SessionId = Login(config);
                    goto band;
                }

                var findResponse = JsonConvert.DeserializeObject<SLErrorResponse>(ex.Message);
                throw new Exception(findResponse.Error.Message.value);
            }
        }

        public static List<T> FindByQuery<T>(CONF config, string queryID) where T : class, new()
        {
        band:
            try
            {
                string jsonQuery = JsonConvert.SerializeObject(new { Query = queryID });

                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                var client = new RestClient(config.Url);
                var request = new RestRequest($"SQLQueries('{queryID}')", Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddCookie("B1SESSION", config.SessionId);
                //request.AddParameter("application/json", jsonQuery, ParameterType.RequestBody);
                var rsp = client.Execute(request);

                if (rsp.StatusCode == HttpStatusCode.NotFound) return null;
                if (rsp.StatusCode != System.Net.HttpStatusCode.OK)
                    throw new ApplicationException(rsp.Content);

                JObject responseContent = JObject.Parse(rsp.Content);
                JToken values = responseContent["value"];
                if (values == null)
                    throw new Exception($"Bad Service Layer response:{rsp.Content}");

                return values.ToObject<List<T>>(); ;
            }
            catch (Exception ex)
            {
                if (ex.Message == "No se logró establecer conexión con Service Layer")
                    throw ex;

                if (ex.Message.Contains("Invalid session"))
                {
                    config.SessionId = Login(config);
                    goto band;
                }

                var findResponse = JsonConvert.DeserializeObject<SLErrorResponse>(ex.Message);
                throw new Exception(findResponse.Error.Message.value);
            }
        }

        public static string Add<T>(CONF config, T @object)
        {
        band:
            try
            {
                string json = JsonConvert.SerializeObject(@object, Globals.Settings<T>());
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                var client = new RestClient(config.Url);
                var request = new RestRequest(Globals.BuildURI(@object), Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddCookie("B1SESSION", config.SessionId);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                var rsp = client.Execute(request);

                if (rsp.StatusCode != System.Net.HttpStatusCode.OK && rsp.StatusCode != System.Net.HttpStatusCode.Created && rsp.StatusCode != System.Net.HttpStatusCode.NoContent && rsp.StatusCode != 0)
                    throw new ApplicationException(rsp.Content);
                return rsp.Content;
            }
            catch (Exception ex)
            {
                if (ex.Message == "No se logró establecer conexión con Service Layer")
                    throw ex;

                if (ex.Message.Contains("Invalid session"))
                {
                    config.SessionId = Login(config);
                    goto band;
                }

                var createResponse = JsonConvert.DeserializeObject<SLErrorResponse>(ex.Message);
                throw new Exception(createResponse.Error.Message.value);
            }
        }

        public static string Update<T>(CONF config, T @object)
        {
        band:
            try
            {
                string json = JsonConvert.SerializeObject(@object, Globals.Settings<T>());
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                var client = new RestClient(config.Url);
                var request = new RestRequest(Globals.BuildURI(@object), Method.PATCH);
                request.AddHeader("content-type", "application/json");
                request.AddCookie("B1SESSION", config.SessionId);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                var rsp = client.Execute(request);

                if (rsp.StatusCode != System.Net.HttpStatusCode.OK && rsp.StatusCode != System.Net.HttpStatusCode.Created && rsp.StatusCode != System.Net.HttpStatusCode.NoContent && rsp.StatusCode != 0)
                    throw new ApplicationException(rsp.Content);
                return rsp.Content;
            }
            catch (Exception ex)
            {
                if (ex.Message == "No se logró establecer conexión con Service Layer")
                    throw ex;

                if (ex.Message.Contains("Invalid session"))
                {
                    config.SessionId = Login(config);
                    goto band;
                }

                var updateResponse = JsonConvert.DeserializeObject<SLErrorResponse>(ex.Message);
                throw new Exception(updateResponse.Error.Message.value);
            }
        }
    }
}