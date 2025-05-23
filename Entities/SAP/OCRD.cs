using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    [SAPEntityName("BusinessPartners")]
    public class OCRD
    {
        [JsonProperty("CardCode"), SAPKey] public string CardCode { get; set; }

        [JsonProperty("CardName")] public string CardName { get; set; }

        [JsonProperty("CardType")] public string CardType { get; set; }

        [JsonProperty("GroupCode")] public int? GroupCode { get; set; }

        [JsonProperty("Address")] public string Address { get; set; }

        [JsonProperty("ZipCode")] public string ZipCode { get; set; }

        [JsonProperty("MailAddress")] public string MailAddress { get; set; }

        [JsonProperty("MailZipCode")] public string MailZipCode { get; set; }

        [JsonProperty("Phone1")] public string Phone1 { get; set; }

        [JsonProperty("Phone2")] public string Phone2 { get; set; }

        [JsonProperty("Fax")] public string Fax { get; set; }

        [JsonProperty("ContactPerson")] public string ContactPerson { get; set; }

        [JsonProperty("Notes")] public string Notes { get; set; }

        [JsonProperty("PayTermsGrpCode")] public int? PayTermsGrpCode { get; set; }

        [JsonProperty("CreditLimit")] public double? CreditLimit { get; set; }

        [JsonProperty("MaxCommitment")] public double? MaxCommitment { get; set; }

        [JsonProperty("DiscountPercent")] public double? DiscountPercent { get; set; }

        [JsonProperty("VatLiable")] public string VatLiable { get; set; }

        [JsonProperty("VatStatus")] public string VatStatus { get; set; }

        [JsonProperty("FederalTaxID")] public string FederalTaxID { get; set; }

        [JsonProperty("DeductibleAtSource")] public string DeductibleAtSource { get; set; }

        [JsonProperty("DeductionPercent")] public double? DeductionPercent { get; set; }

        [JsonProperty("DeductionValidUntil")] public string DeductionValidUntil { get; set; }

        [JsonProperty("PriceListNum")] public int? PriceListNum { get; set; }

        [JsonProperty("IntrestRatePercent")] public double? IntrestRatePercent { get; set; }

        [JsonProperty("CommissionPercent")] public double? CommissionPercent { get; set; }

        [JsonProperty("CommissionGroupCode")] public int? CommissionGroupCode { get; set; }

        [JsonProperty("FreeText")] public string FreeText { get; set; }

        [JsonProperty("SalesPersonCode")] public int? SalesPersonCode { get; set; }

        [JsonProperty("Currency")] public string Currency { get; set; }

        [JsonProperty("RateDiffAccount")] public string RateDiffAccount { get; set; }

        [JsonProperty("Cellular")] public string Cellular { get; set; }
        [JsonProperty("LicTradNum")] public string LicTradNum { get; set; }

        [JsonProperty("AvarageLate")] public string AvarageLate { get; set; }

        [JsonProperty("City")] public string City { get; set; }

        [JsonProperty("County")] public string County { get; set; }

        [JsonProperty("Country")] public string Country { get; set; }

        [JsonProperty("MailCity")] public string MailCity { get; set; }

        [JsonProperty("MailCounty")] public string MailCounty { get; set; }

        [JsonProperty("MailCountry")] public string MailCountry { get; set; }

        [JsonProperty("EmailAddress")] public string EmailAddress { get; set; }

        [JsonProperty("Picture")] public string Picture { get; set; }

        [JsonProperty("DefaultAccount")] public string DefaultAccount { get; set; }

        [JsonProperty("DefaultBranch")] public string DefaultBranch { get; set; }

        [JsonProperty("DefaultBankCode")] public string DefaultBankCode { get; set; }

        [JsonProperty("AdditionalID")] public string AdditionalID { get; set; }

        [JsonProperty("Pager")] public string Pager { get; set; }

        [JsonProperty("FatherCard")] public string FatherCard { get; set; }

        [JsonProperty("CardForeignName")] public string CardForeignName { get; set; }

        [JsonProperty("FatherType")] public string FatherType { get; set; }

        [JsonProperty("DeductionOffice")] public string DeductionOffice { get; set; }

        [JsonProperty("ExportCode")] public string ExportCode { get; set; }

        [JsonProperty("MinIntrest")] public double? MinIntrest { get; set; }

        [JsonProperty("CurrentAccountBalance")] public double? CurrentAccountBalance { get; set; }

        [JsonProperty("OpenDeliveryNotesBalance")] public double? OpenDeliveryNotesBalance { get; set; }

        [JsonProperty("OpenOrdersBalance")] public double? OpenOrdersBalance { get; set; }

        [JsonProperty("VatGroup")] public string VatGroup { get; set; }

        [JsonProperty("ShippingType")] public string ShippingType { get; set; }

        [JsonProperty("Password")] public string Password { get; set; }

        [JsonProperty("Indicator")] public string Indicator { get; set; }

        [JsonProperty("IBAN")] public string IBAN { get; set; }

        [JsonProperty("CreditCardCode")] public int? CreditCardCode { get; set; }

        [JsonProperty("CreditCardNum")] public string CreditCardNum { get; set; }

        [JsonProperty("CreditCardExpiration")] public string CreditCardExpiration { get; set; }

        [JsonProperty("DebitorAccount")] public string DebitorAccount { get; set; }

        [JsonProperty("OpenOpportunities")] public string OpenOpportunities { get; set; }

        [JsonProperty("Valid")] public string Valid { get; set; }

        [JsonProperty("ValidFrom")] public string ValidFrom { get; set; }

        [JsonProperty("ValidTo")] public string ValidTo { get; set; }

        [JsonProperty("ValidRemarks")] public string ValidRemarks { get; set; }

        [JsonProperty("Frozen")] public string Frozen { get; set; }

        [JsonProperty("FrozenFrom")] public string FrozenFrom { get; set; }

        [JsonProperty("FrozenTo")] public string FrozenTo { get; set; }

        [JsonProperty("FrozenRemarks")] public string FrozenRemarks { get; set; }

        [JsonProperty("Block")] public string Block { get; set; }

        [JsonProperty("BillToState")] public string BillToState { get; set; }

        [JsonProperty("ExemptNum")] public string ExemptNum { get; set; }

        [JsonProperty("Priority")] public int? Priority { get; set; }

        [JsonProperty("FormCode1099")] public string FormCode1099 { get; set; }

        [JsonProperty("Box1099")] public string Box1099 { get; set; }

        [JsonProperty("PeymentMethodCode")] public string PeymentMethodCode { get; set; }

        [JsonProperty("BackOrder")] public string BackOrder { get; set; }

        [JsonProperty("PartialDelivery")] public string PartialDelivery { get; set; }

        [JsonProperty("BlockDunning")] public string BlockDunning { get; set; }

        [JsonProperty("BankCountry")] public string BankCountry { get; set; }

        [JsonProperty("HouseBank")] public string HouseBank { get; set; }

        [JsonProperty("HouseBankCountry")] public string HouseBankCountry { get; set; }

        [JsonProperty("HouseBankAccount")] public string HouseBankAccount { get; set; }

        [JsonProperty("ShipToDefault")] public string ShipToDefault { get; set; }

        [JsonProperty("DunningLevel")] public string DunningLevel { get; set; }

        [JsonProperty("DunningDate")] public string DunningDate { get; set; }

        [JsonProperty("CollectionAuthorization")] public string CollectionAuthorization { get; set; }

        [JsonProperty("DME")] public string DME { get; set; }

        [JsonProperty("InstructionKey")] public string InstructionKey { get; set; }

        [JsonProperty("SinglePayment")] public string SinglePayment { get; set; }

        [JsonProperty("ISRBillerID")] public string ISRBillerID { get; set; }

        [JsonProperty("PaymentBlock")] public string PaymentBlock { get; set; }

        [JsonProperty("ReferenceDetails")] public string ReferenceDetails { get; set; }

        [JsonProperty("HouseBankBranch")] public string HouseBankBranch { get; set; }

        [JsonProperty("OwnerIDNumber")] public string OwnerIDNumber { get; set; }

        [JsonProperty("PaymentBlockDescription")] public int? PaymentBlockDescription { get; set; }

        [JsonProperty("TaxExemptionLetterNum")] public string TaxExemptionLetterNum { get; set; }

        [JsonProperty("MaxAmountOfExemption")] public double? MaxAmountOfExemption { get; set; }

        [JsonProperty("ExemptionValidityDateFrom")] public string ExemptionValidityDateFrom { get; set; }

        [JsonProperty("ExemptionValidityDateTo")] public string ExemptionValidityDateTo { get; set; }

        [JsonProperty("LinkedBusinessPartner")] public string LinkedBusinessPartner { get; set; }

        [JsonProperty("LastMultiReconciliationNum")] public string LastMultiReconciliationNum { get; set; }

        [JsonProperty("DeferredTax")] public string DeferredTax { get; set; }

        [JsonProperty("Equalization")] public string Equalization { get; set; }

        [JsonProperty("SubjectToWithholdingTax")] public string SubjectToWithholdingTax { get; set; }

        [JsonProperty("CertificateNumber")] public string CertificateNumber { get; set; }

        [JsonProperty("ExpirationDate")] public string ExpirationDate { get; set; }

        [JsonProperty("NationalInsuranceNum")] public string NationalInsuranceNum { get; set; }

        [JsonProperty("AccrualCriteria")] public string AccrualCriteria { get; set; }

        [JsonProperty("WTCode")] public string WTCode { get; set; }

        [JsonProperty("BillToBuildingFloorRoom")] public string BillToBuildingFloorRoom { get; set; }

        [JsonProperty("DownPaymentClearAct")] public string DownPaymentClearAct { get; set; }

        [JsonProperty("ChannelBP")] public string ChannelBP { get; set; }

        [JsonProperty("DefaultTechnician")] public string DefaultTechnician { get; set; }

        [JsonProperty("BilltoDefault")] public string BilltoDefault { get; set; }

        [JsonProperty("CustomerBillofExchangDisc")] public string CustomerBillofExchangDisc { get; set; }

        [JsonProperty("Territory")] public string Territory { get; set; }

        [JsonProperty("ShipToBuildingFloorRoom")] public string ShipToBuildingFloorRoom { get; set; }

        [JsonProperty("CustomerBillofExchangPres")] public string CustomerBillofExchangPres { get; set; }

        [JsonProperty("ProjectCode")] public string ProjectCode { get; set; }

        [JsonProperty("VatGroupLatinAmerica")] public string VatGroupLatinAmerica { get; set; }

        [JsonProperty("DunningTerm")] public string DunningTerm { get; set; }

        [JsonProperty("Website")] public string Website { get; set; }

        [JsonProperty("OtherReceivablePayable")] public string OtherReceivablePayable { get; set; }

        [JsonProperty("BillofExchangeonCollection")] public string BillofExchangeonCollection { get; set; }

        [JsonProperty("CompanyPrivate")] public string CompanyPrivate { get; set; }

        [JsonProperty("LanguageCode")] public int? LanguageCode { get; set; }

        [JsonProperty("UnpaidBillofExchange")] public string UnpaidBillofExchange { get; set; }

        [JsonProperty("WithholdingTaxDeductionGroup")] public int? WithholdingTaxDeductionGroup { get; set; }

        [JsonProperty("ClosingDateProcedureNumber")] public string ClosingDateProcedureNumber { get; set; }

        [JsonProperty("Profession")] public string Profession { get; set; }

        [JsonProperty("BankChargesAllocationCode")] public string BankChargesAllocationCode { get; set; }

        [JsonProperty("TaxRoundingRule")] public string TaxRoundingRule { get; set; }

        [JsonProperty("Properties1")] public string Properties1 { get; set; }

        [JsonProperty("Properties2")] public string Properties2 { get; set; }

        [JsonProperty("Properties3")] public string Properties3 { get; set; }

        [JsonProperty("Properties4")] public string Properties4 { get; set; }

        [JsonProperty("Properties5")] public string Properties5 { get; set; }

        [JsonProperty("Properties6")] public string Properties6 { get; set; }

        [JsonProperty("Properties7")] public string Properties7 { get; set; }

        [JsonProperty("Properties8")] public string Properties8 { get; set; }

        [JsonProperty("Properties9")] public string Properties9 { get; set; }

        [JsonProperty("Properties10")] public string Properties10 { get; set; }

        [JsonProperty("Properties11")] public string Properties11 { get; set; }

        [JsonProperty("Properties12")] public string Properties12 { get; set; }

        [JsonProperty("Properties13")] public string Properties13 { get; set; }

        [JsonProperty("Properties14")] public string Properties14 { get; set; }

        [JsonProperty("Properties15")] public string Properties15 { get; set; }

        [JsonProperty("Properties16")] public string Properties16 { get; set; }

        [JsonProperty("Properties17")] public string Properties17 { get; set; }

        [JsonProperty("Properties18")] public string Properties18 { get; set; }

        [JsonProperty("Properties19")] public string Properties19 { get; set; }

        [JsonProperty("Properties20")] public string Properties20 { get; set; }

        [JsonProperty("Properties21")] public string Properties21 { get; set; }

        [JsonProperty("Properties22")] public string Properties22 { get; set; }

        [JsonProperty("Properties23")] public string Properties23 { get; set; }

        [JsonProperty("Properties24")] public string Properties24 { get; set; }

        [JsonProperty("Properties25")] public string Properties25 { get; set; }

        [JsonProperty("Properties26")] public string Properties26 { get; set; }

        [JsonProperty("Properties27")] public string Properties27 { get; set; }

        [JsonProperty("Properties28")] public string Properties28 { get; set; }

        [JsonProperty("Properties29")] public string Properties29 { get; set; }

        [JsonProperty("Properties30")] public string Properties30 { get; set; }

        [JsonProperty("Properties31")] public string Properties31 { get; set; }

        [JsonProperty("Properties32")] public string Properties32 { get; set; }

        [JsonProperty("Properties33")] public string Properties33 { get; set; }

        [JsonProperty("Properties34")] public string Properties34 { get; set; }

        [JsonProperty("Properties35")] public string Properties35 { get; set; }

        [JsonProperty("Properties36")] public string Properties36 { get; set; }

        [JsonProperty("Properties37")] public string Properties37 { get; set; }

        [JsonProperty("Properties38")] public string Properties38 { get; set; }

        [JsonProperty("Properties39")] public string Properties39 { get; set; }

        [JsonProperty("Properties40")] public string Properties40 { get; set; }

        [JsonProperty("Properties41")] public string Properties41 { get; set; }

        [JsonProperty("Properties42")] public string Properties42 { get; set; }

        [JsonProperty("Properties43")] public string Properties43 { get; set; }

        [JsonProperty("Properties44")] public string Properties44 { get; set; }

        [JsonProperty("Properties45")] public string Properties45 { get; set; }

        [JsonProperty("Properties46")] public string Properties46 { get; set; }

        [JsonProperty("Properties47")] public string Properties47 { get; set; }

        [JsonProperty("Properties48")] public string Properties48 { get; set; }

        [JsonProperty("Properties49")] public string Properties49 { get; set; }

        [JsonProperty("Properties50")] public string Properties50 { get; set; }

        [JsonProperty("Properties51")] public string Properties51 { get; set; }

        [JsonProperty("Properties52")] public string Properties52 { get; set; }

        [JsonProperty("Properties53")] public string Properties53 { get; set; }

        [JsonProperty("Properties54")] public string Properties54 { get; set; }

        [JsonProperty("Properties55")] public string Properties55 { get; set; }

        [JsonProperty("Properties56")] public string Properties56 { get; set; }

        [JsonProperty("Properties57")] public string Properties57 { get; set; }

        [JsonProperty("Properties58")] public string Properties58 { get; set; }

        [JsonProperty("Properties59")] public string Properties59 { get; set; }

        [JsonProperty("Properties60")] public string Properties60 { get; set; }

        [JsonProperty("Properties61")] public string Properties61 { get; set; }

        [JsonProperty("Properties62")] public string Properties62 { get; set; }

        [JsonProperty("Properties63")] public string Properties63 { get; set; }

        [JsonProperty("Properties64")] public string Properties64 { get; set; }

        [JsonProperty("CompanyRegistrationNumber")] public string CompanyRegistrationNumber { get; set; }

        [JsonProperty("VerificationNumber")] public string VerificationNumber { get; set; }

        [JsonProperty("DiscountBaseObject")] public string DiscountBaseObject { get; set; }

        [JsonProperty("DiscountRelations")] public string DiscountRelations { get; set; }

        [JsonProperty("TypeReport")] public string TypeReport { get; set; }

        [JsonProperty("ThresholdOverlook")] public string ThresholdOverlook { get; set; }

        [JsonProperty("SurchargeOverlook")] public string SurchargeOverlook { get; set; }

        [JsonProperty("DownPaymentInterimAccount")] public string DownPaymentInterimAccount { get; set; }

        [JsonProperty("OperationCode347")] public string OperationCode347 { get; set; }

        [JsonProperty("InsuranceOperation347")] public string InsuranceOperation347 { get; set; }

        [JsonProperty("HierarchicalDeduction")] public string HierarchicalDeduction { get; set; }

        [JsonProperty("ShaamGroup")] public string ShaamGroup { get; set; }

        [JsonProperty("WithholdingTaxCertified")] public string WithholdingTaxCertified { get; set; }

        [JsonProperty("BookkeepingCertified")] public string BookkeepingCertified { get; set; }

        [JsonProperty("PlanningGroup")] public string PlanningGroup { get; set; }

        [JsonProperty("Affiliate")] public string Affiliate { get; set; }

        [JsonProperty("Industry")] public string Industry { get; set; }

        [JsonProperty("VatIDNum")] public string VatIDNum { get; set; }

        [JsonProperty("DatevAccount")] public string DatevAccount { get; set; }

        [JsonProperty("DatevFirstDataEntry")] public string DatevFirstDataEntry { get; set; }

        [JsonProperty("UseShippedGoodsAccount")] public string UseShippedGoodsAccount { get; set; }

        [JsonProperty("GTSRegNo")] public string GTSRegNo { get; set; }

        [JsonProperty("GTSBankAccountNo")] public string GTSBankAccountNo { get; set; }

        [JsonProperty("GTSBillingAddrTel")] public string GTSBillingAddrTel { get; set; }

        [JsonProperty("ETaxWebSite")] public string ETaxWebSite { get; set; }

        [JsonProperty("HouseBankIBAN")] public string HouseBankIBAN { get; set; }

        [JsonProperty("VATRegistrationNumber")] public string VATRegistrationNumber { get; set; }

        [JsonProperty("RepresentativeName")] public string RepresentativeName { get; set; }

        [JsonProperty("IndustryType")] public string IndustryType { get; set; }

        [JsonProperty("BusinessType")] public string BusinessType { get; set; }

        [JsonProperty("Series")] public int? Series { get; set; }

        [JsonProperty("AutomaticPosting")] public string AutomaticPosting { get; set; }

        [JsonProperty("InterestAccount")] public string InterestAccount { get; set; }

        [JsonProperty("FeeAccount")] public string FeeAccount { get; set; }

        [JsonProperty("CampaignNumber")] public string CampaignNumber { get; set; }

        [JsonProperty("AliasName")] public string AliasName { get; set; }

        [JsonProperty("DefaultBlanketAgreementNumber")] public string DefaultBlanketAgreementNumber { get; set; }

        [JsonProperty("EffectiveDiscount")] public string EffectiveDiscount { get; set; }

        [JsonProperty("NoDiscounts")] public string NoDiscounts { get; set; }

        [JsonProperty("EffectivePrice")] public string EffectivePrice { get; set; }

        [JsonProperty("GlobalLocationNumber")] public string GlobalLocationNumber { get; set; }

        [JsonProperty("EDISenderID")] public string EDISenderID { get; set; }

        [JsonProperty("EDIRecipientID")] public string EDIRecipientID { get; set; }

        [JsonProperty("ResidenNumber")] public string ResidenNumber { get; set; }

        [JsonProperty("RelationshipCode")] public string RelationshipCode { get; set; }

        [JsonProperty("RelationshipDateFrom")] public string RelationshipDateFrom { get; set; }

        [JsonProperty("RelationshipDateTill")] public string RelationshipDateTill { get; set; }

        [JsonProperty("UnifiedFederalTaxID")] public string UnifiedFederalTaxID { get; set; }

        [JsonProperty("AttachmentEntry")] public string AttachmentEntry { get; set; }

        [JsonProperty("TypeOfOperation")] public string TypeOfOperation { get; set; }

        [JsonProperty("EndorsableChecksFromBP")] public string EndorsableChecksFromBP { get; set; }

        [JsonProperty("AcceptsEndorsedChecks")] public string AcceptsEndorsedChecks { get; set; }

        [JsonProperty("OwnerCode")] public string OwnerCode { get; set; }

        [JsonProperty("BlockSendingMarketingContent")] public string BlockSendingMarketingContent { get; set; }

        [JsonProperty("AgentCode")] public string AgentCode { get; set; }

        [JsonProperty("PriceMode")] public string PriceMode { get; set; }

        [JsonProperty("EDocGenerationType")] public string EDocGenerationType { get; set; }

        [JsonProperty("EDocStreet")] public string EDocStreet { get; set; }

        [JsonProperty("EDocStreetNumber")] public string EDocStreetNumber { get; set; }

        [JsonProperty("EDocBuildingNumber")] public string EDocBuildingNumber { get; set; }

        [JsonProperty("EDocZipCode")] public string EDocZipCode { get; set; }

        [JsonProperty("EDocCity")] public string EDocCity { get; set; }

        [JsonProperty("EDocCountry")] public string EDocCountry { get; set; }

        [JsonProperty("EDocDistrict")] public string EDocDistrict { get; set; }

        [JsonProperty("EDocRepresentativeFirstName")] public string EDocRepresentativeFirstName { get; set; }

        [JsonProperty("EDocRepresentativeSurname")] public string EDocRepresentativeSurname { get; set; }

        [JsonProperty("EDocRepresentativeCompany")] public string EDocRepresentativeCompany { get; set; }

        [JsonProperty("EDocRepresentativeFiscalCode")] public string EDocRepresentativeFiscalCode { get; set; }

        [JsonProperty("EDocRepresentativeAdditionalId")] public string EDocRepresentativeAdditionalId { get; set; }

        [JsonProperty("EDocPECAddress")] public string EDocPECAddress { get; set; }

        [JsonProperty("IPACodeForPA")] public string IPACodeForPA { get; set; }

        [JsonProperty("UpdateDate")] public string UpdateDate { get; set; }

        [JsonProperty("UpdateTime")] public string UpdateTime { get; set; }

        [JsonProperty("ExemptionMaxAmountValidationType")] public string ExemptionMaxAmountValidationType { get; set; }

        [JsonProperty("ECommerceMerchantID")] public string ECommerceMerchantID { get; set; }

        [JsonProperty("UseBillToAddrToDetermineTax")] public string UseBillToAddrToDetermineTax { get; set; }

        [JsonProperty("CreateDate")] public string CreateDate { get; set; }

        [JsonProperty("CreateTime")] public string CreateTime { get; set; }

        [JsonProperty("DefaultTransporterEntry")] public string DefaultTransporterEntry { get; set; }

        [JsonProperty("DefaultTransporterLineNumber")] public string DefaultTransporterLineNumber { get; set; }

        [JsonProperty("FCERelevant")] public string FCERelevant { get; set; }
        [JsonProperty("U_EXT_CORREO")] public string U_EXT_CORREO { get; set; }
        

        //[JsonProperty("U_VS_SNREL")] public  string UVSSNREL { get; set; }

        //[JsonProperty("U_VS_AVALNOM")] public  string UVSAVALNOM { get; set; }

        //[JsonProperty("U_VS_AVALDIR")] public  string UVSAVALDIR { get; set; }

        //[JsonProperty("U_VS_AVALLOC")] public  string UVSAVALLOC { get; set; }

        //[JsonProperty("U_VS_AVALDOI")] public  string UVSAVALDOI { get; set; }

        //[JsonProperty("U_VS_AVALTEL")] public  string UVSAVALTEL { get; set; }

        //[JsonProperty("U_BPP_BPTP")] public  string UBPPBPTP { get; set; }

        //[JsonProperty("U_BPP_BPTD")] public  string UBPPBPTD { get; set; }

        //[JsonProperty("U_BPP_BPAP")] public  string UBPPBPAP { get; set; }

        //[JsonProperty("U_BPP_BPAM")] public  string UBPPBPAM { get; set; }

        //[JsonProperty("U_BPP_BPNO")] public  string UBPPBPNO { get; set; }

        //[JsonProperty("U_BPP_BPN2")] public  string UBPPBPN2 { get; set; }

        //[JsonProperty("U_BPP_BPAT")] public  string UBPPBPAT { get; set; }

        //[JsonProperty("U_VS_IMPTOSC")] public  string UVSIMPTOSC { get; set; }

        //[JsonProperty("U_VS_NEGOCIO")] public  string UVSNEGOCIO { get; set; }

        //[JsonProperty("U_VS_EXCCOD")] public  string UVSEXCCOD { get; set; }

        //[JsonProperty("U_VS_AFPRCP")] public  string UVSAFPRCP { get; set; }

        //[JsonProperty("U_VS_NOMCOM")] public  string UVSNOMCOM { get; set; }

        //[JsonProperty("U_VS_CANAL")] public  string UVSCANAL { get; set; }

        //[JsonProperty("U_VS_ESTCON")] public  string UVSESTCON { get; set; }

        //[JsonProperty("U_VS_CONCON")] public  string UVSCONCON { get; set; }
        //[JsonProperty("U_VS_ESTCNT")] public  string? UVSESTCNT { get; set; } = "";

        //[JsonProperty("U_VS_CONCNT")] public  string UVSCONCNT { get; set; }

        //[JsonProperty("U_VS_AGRET")] public  string UVSAGRET { get; set; }

        //[JsonProperty("U_VS_AGPER")] public  string UVSAGPER { get; set; }

        //[JsonProperty("U_VS_BCON")] public  string UVSBCON { get; set; }

        //[JsonProperty("U_VS_FECACT")] public  string UVSFECACT { get; set; }

        //[JsonProperty("U_VALIDC")] public  string UVALIDC { get; set; }

        //[JsonProperty("U_VS_MAIL_SEC")] public  string UVSMAILSEC { get; set; }

        //[JsonProperty("U_VS_CUFE")] public  string UVSCUFE { get; set; }

        //[JsonProperty("U_VS_IDBENF")] public  string UVSIDBENF { get; set; }

        //[JsonProperty("U_VS_RZBENF")] public  string UVSRZBENF { get; set; }

        //[JsonProperty("U_VS_PAISBF")] public  string UVSPAISBF { get; set; }

        //[JsonProperty("U_VS_VINCUL")] public  string UVSVINCUL { get; set; }
        public Dictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();

        [JsonProperty("BPAddresses")] public List<BPAddress> BPAddresses { get; set; }

        [JsonProperty("ContactEmployees")] public List<ContactEmployee> ContactEmployees { get; set; }

        [JsonProperty("BPAccountReceivablePaybleCollection")] private List<BPAccountReceivablePaybleCollection> BPAccountReceivablePaybleCollection { get; set; }

        [JsonProperty("BPWithholdingTaxCollection")] public List<BPWithholdingTaxCollection> BPWithholdingTaxCollection { get; set; }

        [JsonProperty("BPPaymentMethods")] public List<BPPaymentMethods> BPPaymentMethods { get; set; }

        [JsonProperty("BPFiscalTaxIDCollection")] public List<object> BPFiscalTaxIDCollection { get; set; }

        [JsonProperty("DiscountGroups")] public List<object> DiscountGroups { get; set; }
    }

    public class ContactEmployee
    {
        [JsonProperty("CardCode")] public string CardCode { get; set; }

        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("Position")] public string Position { get; set; }

        [JsonProperty("Address")] public string Address { get; set; }

        [JsonProperty("Phone1")] public string Phone1 { get; set; }

        [JsonProperty("Phone2")] public string Phone2 { get; set; }

        [JsonProperty("MobilePhone")] public string MobilePhone { get; set; }

        [JsonProperty("Fax")] public string Fax { get; set; }

        [JsonProperty("E_Mail")] public string EMail { get; set; }

        [JsonProperty("Pager")] public string Pager { get; set; }

        [JsonProperty("Remarks1")] public string Remarks1 { get; set; }

        [JsonProperty("Remarks2")] public string Remarks2 { get; set; }

        [JsonProperty("Password")] public string Password { get; set; }

        [JsonProperty("InternalCode")] public int? InternalCode { get; set; }

        [JsonProperty("PlaceOfBirth")] public string PlaceOfBirth { get; set; }

        [JsonProperty("DateOfBirth")] public string DateOfBirth { get; set; }

        [JsonProperty("Gender")] public string Gender { get; set; }

        [JsonProperty("Profession")] public string Profession { get; set; }

        [JsonProperty("Title")] public string Title { get; set; }

        [JsonProperty("CityOfBirth")] public string CityOfBirth { get; set; }

        [JsonProperty("Active")] public string Active { get; set; }

        [JsonProperty("FirstName")] public string FirstName { get; set; }

        [JsonProperty("MiddleName")] public string MiddleName { get; set; }

        [JsonProperty("LastName")] public string LastName { get; set; }

        [JsonProperty("EmailGroupCode")] public string EmailGroupCode { get; set; }

        [JsonProperty("BlockSendingMarketingContent")] public string BlockSendingMarketingContent { get; set; }

        [JsonProperty("CreateDate")] public string CreateDate { get; set; }

        [JsonProperty("CreateTime")] public string CreateTime { get; set; }

        [JsonProperty("UpdateDate")] public string UpdateDate { get; set; }

        [JsonProperty("UpdateTime")] public string UpdateTime { get; set; }
        [JsonProperty("U_EXX_NUMDOC")] public string UEXXNUMDOC { get; set; }
    }


    public class BPAddress
    {
        [JsonProperty("AddressName")] public string AddressName { get; set; }

        [JsonProperty("Street")] public string Street { get; set; }

        [JsonProperty("Block")] public string Block { get; set; }

        [JsonProperty("ZipCode")] public string ZipCode { get; set; }

        [JsonProperty("City")] public string City { get; set; }

        [JsonProperty("County")] public string County { get; set; }

        [JsonProperty("Country")] public string Country { get; set; }

        [JsonProperty("State")] public string State { get; set; }

        [JsonProperty("FederalTaxID")] public string FederalTaxID { get; set; }

        [JsonProperty("TaxCode")] public string TaxCode { get; set; }

        [JsonProperty("BuildingFloorRoom")] public string BuildingFloorRoom { get; set; }

        [JsonProperty("AddressType")] public string AddressType { get; set; }

        [JsonProperty("AddressName2")] public string AddressName2 { get; set; }

        [JsonProperty("AddressName3")] public string AddressName3 { get; set; }

        [JsonProperty("TypeOfAddress")] public string TypeOfAddress { get; set; }

        [JsonProperty("StreetNo")] public string StreetNo { get; set; }

        [JsonProperty("BPCode")] public string BPCode { get; set; }

        [JsonProperty("RowNum")] public int? RowNum { get; set; }

        [JsonProperty("GlobalLocationNumber")] public string GlobalLocationNumber { get; set; }

        [JsonProperty("Nationality")] public string Nationality { get; set; }

        [JsonProperty("TaxOffice")] public string TaxOffice { get; set; }

        [JsonProperty("GSTIN")] public string GSTIN { get; set; }

        [JsonProperty("GstType")] public string GstType { get; set; }

        [JsonProperty("U_EXI_LATITUD")] public string UEXILATITUD { get; set; }
        [JsonProperty("U_EXI_LONGITUD")] public string U_EXI_LONGITUD { get; set; }
        [JsonProperty("U_EXI_HORAINICIO1")] public string UEXIHORAINICIO1 { get; set; }
        [JsonProperty("U_EXI_HORAFIN1")] public string U_EXI_HORAFIN1 { get; set; }
        [JsonProperty("U_EXI_HORAINICIO2")] public string U_EXI_HORAINICIO2 { get; set; }
        [JsonProperty("U_EXI_HORAFIN2")] public string U_EXI_HORAFIN2 { get; set; }
        //[JsonProperty("CreateDate")] public  string CreateDate { get; set; }

        //[JsonProperty("CreateTime")] public  string CreateTime { get; set; }

        //public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();
    }

    public class BPAccountReceivablePaybleCollection
    {
        [JsonProperty("AccountType")] public string AccountType { get; set; }

        [JsonProperty("AccountCode")] public string AccountCode { get; set; }

        [JsonProperty("BPCode")] public string BPCode { get; set; }

        public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();
    }

    public class BPWithholdingTaxCollection
    {
        [JsonProperty("WTCode")] public string WTCode { get; set; }
        [JsonProperty("BPCode")] public string BPCode { get; set; }

        public Dictionary<string, object> AdditionalDataDetail { get; set; } = new Dictionary<string, object>();

    }

    public class BPPaymentMethods
    {
        [JsonProperty("PaymentMethodCode")] public string PaymentMethodCode { get; set; }
        [JsonProperty("RowNumber")] public string RowNumber { get; set; }
        [JsonProperty("BPCode")] public string BPCode { get; set; }

    }


}