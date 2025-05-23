using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Framework
{
    public class DynamicConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var jsonObject = new JObject();
            var properties = value.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var propValue = property.GetValue(value);

                // Ignorar valores nulos, vacíos y AdditionalData
                if (propValue != null && !IsDefaultValue(propValue) && property.Name != "AdditionalData")
                {
                    // Verificar si es una lista
                    if (typeof(IEnumerable<object>).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                    {
                        var listValue = propValue as IEnumerable<object>;
                        if (listValue != null && listValue.Any())
                        {
                            var filteredList = new JArray();
                            foreach (var item in listValue)
                            {
                                if (item != null)
                                {
                                    var itemObject = JObject.FromObject(item, serializer);
                                    var detailProperties = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                                    foreach (var detailProperty in detailProperties)
                                    {
                                        if (detailProperty.Name == "AdditionalDataDetail")
                                        {
                                            var additionalDataDetail = detailProperty.GetValue(item) as Dictionary<string, object>;

                                            if (additionalDataDetail != null && additionalDataDetail.Any())
                                            {
                                                foreach (var key in additionalDataDetail.Keys)
                                                {
                                                    if (key.StartsWith("U_"))
                                                    {
                                                        var detailValue = additionalDataDetail[key];
                                                        if (detailValue != null)
                                                        {
                                                            itemObject.Add($"{key}", JToken.FromObject(detailValue, serializer));
                                                        }
                                                    }
                                                }
                                            }

                                            // Si AdditionalDataDetail está vacío, no lo agregues al JSON
                                            itemObject.Remove("AdditionalDataDetail");
                                        }
                                    }

                                    //filteredList.Add(itemObject);
                                    if (itemObject.HasValues)
                                    {
                                        filteredList.Add(itemObject);
                                    }
                                }
                            }

                            if (filteredList.HasValues)
                            {
                                jsonObject.Add(property.Name, filteredList);
                            }
                        }
                    }
                    else
                    {
                        jsonObject.Add(property.Name, JToken.FromObject(propValue, serializer));
                    }
                }
            }

            var additionalDataProperty = value.GetType().GetProperty("AdditionalData");
            if (additionalDataProperty != null)
            {
                var additionalData = additionalDataProperty.GetValue(value) as Dictionary<string, object>;
                foreach (var key in additionalData.Keys)
                {
                    if (key.StartsWith("U_") && additionalData[key] != null)
                    {
                        jsonObject.Add(key, JToken.FromObject(additionalData[key]));
                    }
                }

                jsonObject.Remove("AdditionalData");
            }

            jsonObject.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var target = Activator.CreateInstance<T>();

            // Deserializa las propiedades del objeto principal
            serializer.Populate(jsonObject.CreateReader(), target);

            // Manejo de AdditionalData
            var additionalDataProperty = target.GetType().GetProperty("AdditionalData");
            if (additionalDataProperty != null)
            {
                var additionalData = new Dictionary<string, object>();
                foreach (var property in jsonObject.Properties())
                {
                    if (property.Name.StartsWith("U_"))
                    {
                        additionalData[property.Name] = property.Value.ToObject<object>();
                    }
                }
                additionalDataProperty.SetValue(target, additionalData);
            }

            foreach (var property in target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (typeof(IEnumerable<object>).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                {
                    var listValue = property.GetValue(target) as IEnumerable<object>;
                    if (listValue != null)
                    {
                        foreach (var item in listValue)
                        {
                            if (item != null)
                            {
                                var itemJsonObject = jsonObject[property.Name] as JArray;
                                if (itemJsonObject != null)
                                {
                                    var itemIndex = 0;
                                    foreach (var detailToken in itemJsonObject)
                                    {
                                        var detailJsonObject = detailToken as JObject;
                                        var detailProperties = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                                        foreach (var detailProperty in detailProperties)
                                        {
                                            if (detailProperty.Name == "AdditionalDataDetail")
                                            {
                                                var additionalDataDetail = new Dictionary<string, object>();
                                                foreach (var detailJsonProp in detailJsonObject.Properties())
                                                {
                                                    if (detailJsonProp.Name.StartsWith("U_"))
                                                    {
                                                        additionalDataDetail[detailJsonProp.Name] = detailJsonProp.Value.ToObject<object>();
                                                    }
                                                }
                                                detailProperty.SetValue(item, additionalDataDetail);
                                            }
                                        }

                                        itemIndex++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //// Manejo de listas de detalles
            //foreach (var property in target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            //{
            //    if (typeof(IEnumerable<object>).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
            //    {
            //        var listValue = property.GetValue(target) as IEnumerable<object>;
            //        if (listValue != null)
            //        {
            //            foreach (var item in listValue)
            //            {
            //                if (item != null)
            //                {
            //                    // Busca y procesa AdditionalDataDetail en cada detalle
            //                    var detailProperties = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            //                    foreach (var detailProperty in detailProperties)
            //                    {
            //                        if (detailProperty.Name == "AdditionalDataDetail")
            //                        {
            //                            var additionalDataDetail = new Dictionary<string, object>();
            //                            foreach (var jsonProp in jsonObject.Properties())
            //                            {
            //                                if (jsonProp.Name.StartsWith($"{property.Name}_U_"))
            //                                {
            //                                    var key = jsonProp.Name.Substring($"{property.Name}_".Length);
            //                                    additionalDataDetail[key] = jsonProp.Value.ToObject<object>();
            //                                }
            //                            }
            //                            detailProperty.SetValue(item, additionalDataDetail);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            return target;
        }

        private bool IsDefaultValue(object value)
        {
            if (value is string str && string.IsNullOrEmpty(str))
                return true;

            if (value is IEnumerable<object> collection && !collection.Any())
                return true;

            return false;
        }
    }
}
