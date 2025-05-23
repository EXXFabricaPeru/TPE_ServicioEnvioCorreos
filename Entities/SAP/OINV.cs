using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    [SAPEntityName("Invoices")]
    public class OINV
    {
        [JsonProperty("DocEntry"), SAPKey] public int? DocEntry { get; set; }

        [JsonProperty("DocNum")] public int? DocNum { get; set; }

        [JsonProperty("DocType")] public string DocType { get; set; }

        [JsonProperty("HandWritten")] public string HandWritten { get; set; }

        [JsonProperty("Printed")] public string Printed { get; set; }

        [JsonProperty("DocDate")] public string DocDate { get; set; }

        [JsonProperty("DocDueDate")] public string DocDueDate { get; set; }

        [JsonProperty("CardCode")] public string CardCode { get; set; }

        [JsonProperty("CardName")] public string CardName { get; set; }

        [JsonProperty("Address")] public string Address { get; set; }

        [JsonProperty("NumAtCard")] public string NumAtCard { get; set; }

        [JsonProperty("DocTotal")] public double? DocTotal { get; set; }

        [JsonProperty("AttachmentEntry")] public string AttachmentEntry { get; set; }

        [JsonProperty("DocCurrency")] public string DocCurrency { get; set; }

        [JsonProperty("DocRate")] public double? DocRate { get; set; }

        [JsonProperty("Reference1")] public string Reference1 { get; set; }

        [JsonProperty("Reference2")] public string Reference2 { get; set; }

        [JsonProperty("Comments")] public string Comments { get; set; }

        [JsonProperty("JournalMemo")] public string JournalMemo { get; set; }

        [JsonProperty("PaymentGroupCode")] public string PaymentGroupCode { get; set; }

        [JsonProperty("DocTime")] public string DocTime { get; set; }

        [JsonProperty("SalesPersonCode")] public int? SalesPersonCode { get; set; }

        [JsonProperty("TransportationCode")] public int? TransportationCode { get; set; }

        [JsonProperty("Confirmed")] public string Confirmed { get; set; }

        [JsonProperty("ImportFileNum")] public int? ImportFileNum { get; set; }

        [JsonProperty("SummeryType")] public string SummeryType { get; set; }

        [JsonProperty("ContactPersonCode")] public int? ContactPersonCode { get; set; }

        [JsonProperty("ShowSCN")] public string ShowSCN { get; set; }

        [JsonProperty("Series")] public int? Series { get; set; }

        [JsonProperty("TaxDate")] public string TaxDate { get; set; }

        [JsonProperty("PartialSupply")] public string PartialSupply { get; set; }

        [JsonProperty("DocObjectCode")] public string DocObjectCode { get; set; }

        [JsonProperty("ShipToCode")] public string ShipToCode { get; set; }

        [JsonProperty("Indicator")] public string Indicator { get; set; }

        [JsonProperty("FederalTaxID")] public string FederalTaxID { get; set; }

        [JsonProperty("DiscountPercent")] public double? DiscountPercent { get; set; }

        [JsonProperty("PaymentReference")] public string PaymentReference { get; set; }

        [JsonProperty("CreationDate")] public string CreationDate { get; set; }

        [JsonProperty("UpdateDate")] public string UpdateDate { get; set; }

        [JsonProperty("FinancialPeriod")] public int? FinancialPeriod { get; set; }

        [JsonProperty("TransNum")] public string TransNum { get; set; }

        [JsonProperty("VatSum")] public double? VatSum { get; set; }

        [JsonProperty("VatSumSys")] public double? VatSumSys { get; set; }

        [JsonProperty("VatSumFc")] public double? VatSumFc { get; set; }

        [JsonProperty("NetProcedure")] public string NetProcedure { get; set; }

        [JsonProperty("DocTotalFc")] public double? DocTotalFc { get; set; }

        [JsonProperty("DocTotalSys")] public double? DocTotalSys { get; set; }

        [JsonProperty("Form1099")] public string Form1099 { get; set; }

        [JsonProperty("Box1099")] public string Box1099 { get; set; }

        [JsonProperty("RevisionPo")] public string RevisionPo { get; set; }

        [JsonProperty("RequriedDate")] public string RequriedDate { get; set; }

        [JsonProperty("CancelDate")] public string CancelDate { get; set; }

        [JsonProperty("BlockDunning")] public string BlockDunning { get; set; }

        [JsonProperty("Submitted")] public string Submitted { get; set; }

        [JsonProperty("Segment")] public int? Segment { get; set; }

        [JsonProperty("PickStatus")] public string PickStatus { get; set; }

        [JsonProperty("Pick")] public string Pick { get; set; }

        [JsonProperty("PaymentMethod")] public string PaymentMethod { get; set; }

        [JsonProperty("PaymentBlock")] public string PaymentBlock { get; set; }

        [JsonProperty("PaymentBlockEntry")] public string PaymentBlockEntry { get; set; }

        [JsonProperty("CentralBankIndicator")] public string CentralBankIndicator { get; set; }

        [JsonProperty("MaximumCashDiscount")] public string MaximumCashDiscount { get; set; }

        [JsonProperty("Reserve")] public string Reserve { get; set; }

        [JsonProperty("Project")] public string Project { get; set; }

        [JsonProperty("ExemptionValidityDateFrom")] public string ExemptionValidityDateFrom { get; set; }

        [JsonProperty("ExemptionValidityDateTo")] public string ExemptionValidityDateTo { get; set; }

        [JsonProperty("WareHouseUpdateType")] public string WareHouseUpdateType { get; set; }

        [JsonProperty("Rounding")] public string Rounding { get; set; }

        [JsonProperty("ExternalCorrectedDocNum")] public string ExternalCorrectedDocNum { get; set; }

        [JsonProperty("InternalCorrectedDocNum")] public string InternalCorrectedDocNum { get; set; }

        [JsonProperty("NextCorrectingDocument")] public string NextCorrectingDocument { get; set; }

        [JsonProperty("DeferredTax")] public string DeferredTax { get; set; }

        [JsonProperty("TaxExemptionLetterNum")] public string TaxExemptionLetterNum { get; set; }

        [JsonProperty("WTApplied")] public double? WTApplied { get; set; }

        [JsonProperty("WTAppliedFC")] public double? WTAppliedFC { get; set; }

        [JsonProperty("BillOfExchangeReserved")] public string BillOfExchangeReserved { get; set; }

        [JsonProperty("AgentCode")] public string AgentCode { get; set; }

        [JsonProperty("WTAppliedSC")] public double? WTAppliedSC { get; set; }

        [JsonProperty("TotalEqualizationTax")] public double? TotalEqualizationTax { get; set; }

        [JsonProperty("TotalEqualizationTaxFC")] public double? TotalEqualizationTaxFC { get; set; }

        [JsonProperty("TotalEqualizationTaxSC")] public double? TotalEqualizationTaxSC { get; set; }

        [JsonProperty("NumberOfInstallments")] public int? NumberOfInstallments { get; set; }

        [JsonProperty("ApplyTaxOnFirstInstallment")] public string ApplyTaxOnFirstInstallment { get; set; }

        [JsonProperty("WTNonSubjectAmount")] public double? WTNonSubjectAmount { get; set; }

        [JsonProperty("WTNonSubjectAmountSC")] public double? WTNonSubjectAmountSC { get; set; }

        [JsonProperty("WTNonSubjectAmountFC")] public double? WTNonSubjectAmountFC { get; set; }

        [JsonProperty("WTExemptedAmount")] public double? WTExemptedAmount { get; set; }

        [JsonProperty("WTExemptedAmountSC")] public double? WTExemptedAmountSC { get; set; }

        [JsonProperty("WTExemptedAmountFC")] public double? WTExemptedAmountFC { get; set; }

        [JsonProperty("BaseAmount")] public double? BaseAmount { get; set; }

        [JsonProperty("BaseAmountSC")] public double? BaseAmountSC { get; set; }

        [JsonProperty("BaseAmountFC")] public double? BaseAmountFC { get; set; }

        [JsonProperty("WTAmount")] public double? WTAmount { get; set; }

        [JsonProperty("WTAmountSC")] public double? WTAmountSC { get; set; }

        [JsonProperty("WTAmountFC")] public double? WTAmountFC { get; set; }

        [JsonProperty("VatDate")] public string VatDate { get; set; }

        [JsonProperty("DocumentsOwner")] public string DocumentsOwner { get; set; }

        [JsonProperty("FolioPrefixString")] public string FolioPrefixString { get; set; }

        [JsonProperty("FolioNumber")] public string FolioNumber { get; set; }

        [JsonProperty("DocumentSubType")] public string DocumentSubType { get; set; }

        [JsonProperty("BPChannelCode")] public string BPChannelCode { get; set; }

        [JsonProperty("BPChannelContact")] public int? BPChannelContact { get; set; }

        [JsonProperty("Address2")] public string Address2 { get; set; }

        [JsonProperty("DocumentStatus")] public string DocumentStatus { get; set; }

        [JsonProperty("PeriodIndicator")] public string PeriodIndicator { get; set; }

        [JsonProperty("PayToCode")] public string PayToCode { get; set; }

        [JsonProperty("ManualNumber")] public string ManualNumber { get; set; }

        [JsonProperty("UseShpdGoodsAct")] public string UseShpdGoodsAct { get; set; }

        [JsonProperty("IsPayToBank")] public string IsPayToBank { get; set; }

        [JsonProperty("PayToBankCountry")] public string PayToBankCountry { get; set; }

        [JsonProperty("PayToBankCode")] public string PayToBankCode { get; set; }

        [JsonProperty("PayToBankAccountNo")] public string PayToBankAccountNo { get; set; }

        [JsonProperty("PayToBankBranch")] public string PayToBankBranch { get; set; }

        [JsonProperty("BPL_IDAssignedToInvoice")] public int? BPL_IDAssignedToInvoice { get; set; }

        [JsonProperty("DownPayment")] public double? DownPayment { get; set; }

        [JsonProperty("ReserveInvoice")] public string ReserveInvoice { get; set; }

        [JsonProperty("LanguageCode")] public int? LanguageCode { get; set; }

        [JsonProperty("TrackingNumber")] public string TrackingNumber { get; set; }

        [JsonProperty("PickRemark")] public string PickRemark { get; set; }

        [JsonProperty("ClosingDate")] public string ClosingDate { get; set; }

        [JsonProperty("SequenceCode")] public string SequenceCode { get; set; }

        [JsonProperty("SequenceSerial")] public string SequenceSerial { get; set; }

        [JsonProperty("SeriesString")] public string SeriesString { get; set; }

        [JsonProperty("SubSeriesString")] public string SubSeriesString { get; set; }

        [JsonProperty("SequenceModel")] public string SequenceModel { get; set; }

        [JsonProperty("UseCorrectionVATGroup")] public string UseCorrectionVATGroup { get; set; }

        [JsonProperty("TotalDiscount")] public double? TotalDiscount { get; set; }

        [JsonProperty("DownPaymentAmount")] public double? DownPaymentAmount { get; set; }

        [JsonProperty("DownPaymentPercentage")] public double? DownPaymentPercentage { get; set; }

        [JsonProperty("DownPaymentType")] public string DownPaymentType { get; set; }

        [JsonProperty("DownPaymentAmountSC")] public double? DownPaymentAmountSC { get; set; }

        [JsonProperty("DownPaymentAmountFC")] public double? DownPaymentAmountFC { get; set; }

        [JsonProperty("VatPercent")] public double? VatPercent { get; set; }

        [JsonProperty("ServiceGrossProfitPercent")] public double? ServiceGrossProfitPercent { get; set; }

        [JsonProperty("OpeningRemarks")] public string OpeningRemarks { get; set; }

        [JsonProperty("ClosingRemarks")] public string ClosingRemarks { get; set; }

        [JsonProperty("RoundingDiffAmount")] public double? RoundingDiffAmount { get; set; }

        [JsonProperty("RoundingDiffAmountFC")] public double? RoundingDiffAmountFC { get; set; }

        [JsonProperty("RoundingDiffAmountSC")] public double? RoundingDiffAmountSC { get; set; }

        [JsonProperty("Cancelled")] public string Cancelled { get; set; }

        [JsonProperty("SignatureInputMessage")] public string SignatureInputMessage { get; set; }

        [JsonProperty("SignatureDigest")] public string SignatureDigest { get; set; }

        [JsonProperty("CertificationNumber")] public string CertificationNumber { get; set; }

        [JsonProperty("PrivateKeyVersion")] public string PrivateKeyVersion { get; set; }

        [JsonProperty("ControlAccount")] public string ControlAccount { get; set; }

        [JsonProperty("InsuranceOperation347")] public string InsuranceOperation347 { get; set; }

        [JsonProperty("ArchiveNonremovableSalesQuotation")] public string ArchiveNonremovableSalesQuotation { get; set; }

        [JsonProperty("GTSChecker")] public string GTSChecker { get; set; }

        [JsonProperty("GTSPayee")] public string GTSPayee { get; set; }

        [JsonProperty("ExtraMonth")] public int? ExtraMonth { get; set; }

        [JsonProperty("ExtraDays")] public int? ExtraDays { get; set; }

        [JsonProperty("CashDiscountDateOffset")] public int? CashDiscountDateOffset { get; set; }

        [JsonProperty("StartFrom")] public string StartFrom { get; set; }

        [JsonProperty("NTSApproved")] public string NTSApproved { get; set; }

        [JsonProperty("ETaxWebSite")] public string ETaxWebSite { get; set; }

        [JsonProperty("ETaxNumber")] public string ETaxNumber { get; set; }

        [JsonProperty("NTSApprovedNumber")] public string NTSApprovedNumber { get; set; }

        [JsonProperty("EDocGenerationType")] public string EDocGenerationType { get; set; }

        [JsonProperty("EDocSeries")] public string EDocSeries { get; set; }

        [JsonProperty("EDocNum")] public string EDocNum { get; set; }

        [JsonProperty("EDocExportFormat")] public string EDocExportFormat { get; set; }

        [JsonProperty("EDocStatus")] public string EDocStatus { get; set; }

        [JsonProperty("EDocErrorCode")] public string EDocErrorCode { get; set; }

        [JsonProperty("EDocErrorMessage")] public string EDocErrorMessage { get; set; }

        [JsonProperty("DownPaymentStatus")] public string DownPaymentStatus { get; set; }

        [JsonProperty("GroupSeries")] public string GroupSeries { get; set; }

        [JsonProperty("GroupNumber")] public string GroupNumber { get; set; }

        [JsonProperty("GroupHandWritten")] public string GroupHandWritten { get; set; }

        [JsonProperty("ReopenOriginalDocument")] public string ReopenOriginalDocument { get; set; }

        [JsonProperty("ReopenManuallyClosedOrCanceledDocument")] public string ReopenManuallyClosedOrCanceledDocument { get; set; }

        [JsonProperty("CreateOnlineQuotation")] public string CreateOnlineQuotation { get; set; }

        [JsonProperty("POSEquipmentNumber")] public string POSEquipmentNumber { get; set; }

        [JsonProperty("POSManufacturerSerialNumber")] public string POSManufacturerSerialNumber { get; set; }

        [JsonProperty("POSCashierNumber")] public string POSCashierNumber { get; set; }

        [JsonProperty("ApplyCurrentVATRatesForDownPaymentsToDraw")] public string ApplyCurrentVATRatesForDownPaymentsToDraw { get; set; }

        [JsonProperty("ClosingOption")] public string ClosingOption { get; set; }

        [JsonProperty("SpecifiedClosingDate")] public string SpecifiedClosingDate { get; set; }

        [JsonProperty("OpenForLandedCosts")] public string OpenForLandedCosts { get; set; }

        [JsonProperty("AuthorizationStatus")] public string AuthorizationStatus { get; set; }

        [JsonProperty("TotalDiscountFC")] public double? TotalDiscountFC { get; set; }

        [JsonProperty("TotalDiscountSC")] public double? TotalDiscountSC { get; set; }

        [JsonProperty("RelevantToGTS")] public string RelevantToGTS { get; set; }

        [JsonProperty("BPLName")] public string BPLName { get; set; }

        [JsonProperty("VATRegNum")] public string VATRegNum { get; set; }

        [JsonProperty("AnnualInvoiceDeclarationReference")] public string AnnualInvoiceDeclarationReference { get; set; }

        [JsonProperty("Supplier")] public string Supplier { get; set; }

        [JsonProperty("Releaser")] public string Releaser { get; set; }

        [JsonProperty("Receiver")] public string Receiver { get; set; }

        [JsonProperty("BlanketAgreementNumber")] public string BlanketAgreementNumber { get; set; }

        [JsonProperty("IsAlteration")] public string IsAlteration { get; set; }

        [JsonProperty("CancelStatus")] public string CancelStatus { get; set; }

        [JsonProperty("AssetValueDate")] public string AssetValueDate { get; set; }

        [JsonProperty("DocumentDelivery")] public string DocumentDelivery { get; set; }

        [JsonProperty("AuthorizationCode")] public string AuthorizationCode { get; set; }

        [JsonProperty("StartDeliveryDate")] public string StartDeliveryDate { get; set; }

        [JsonProperty("StartDeliveryTime")] public string StartDeliveryTime { get; set; }

        [JsonProperty("EndDeliveryDate")] public string EndDeliveryDate { get; set; }

        [JsonProperty("EndDeliveryTime")] public string EndDeliveryTime { get; set; }

        [JsonProperty("VehiclePlate")] public string VehiclePlate { get; set; }

        [JsonProperty("ATDocumentType")] public string ATDocumentType { get; set; }

        [JsonProperty("ElecCommStatus")] public string ElecCommStatus { get; set; }

        [JsonProperty("ElecCommMessage")] public string ElecCommMessage { get; set; }

        [JsonProperty("ReuseDocumentNum")] public string ReuseDocumentNum { get; set; }

        [JsonProperty("ReuseNotaFiscalNum")] public string ReuseNotaFiscalNum { get; set; }

        [JsonProperty("PrintSEPADirect")] public string PrintSEPADirect { get; set; }

        [JsonProperty("FiscalDocNum")] public string FiscalDocNum { get; set; }

        [JsonProperty("POSDailySummaryNo")] public string POSDailySummaryNo { get; set; }

        [JsonProperty("POSReceiptNo")] public string POSReceiptNo { get; set; }

        [JsonProperty("PointOfIssueCode")] public string PointOfIssueCode { get; set; }

        [JsonProperty("Letter")] public string Letter { get; set; }

        [JsonProperty("FolioNumberFrom")] public string FolioNumberFrom { get; set; }

        [JsonProperty("FolioNumberTo")] public string FolioNumberTo { get; set; }

        [JsonProperty("InterimType")] public string InterimType { get; set; }

        [JsonProperty("RelatedType")] public int? RelatedType { get; set; }

        [JsonProperty("RelatedEntry")] public string RelatedEntry { get; set; }

        [JsonProperty("SAPPassport")] public string SAPPassport { get; set; }

        [JsonProperty("DocumentTaxID")] public string DocumentTaxID { get; set; }

        [JsonProperty("DateOfReportingControlStatementVAT")] public string DateOfReportingControlStatementVAT { get; set; }

        [JsonProperty("ReportingSectionControlStatementVAT")] public string ReportingSectionControlStatementVAT { get; set; }

        [JsonProperty("ExcludeFromTaxReportControlStatementVAT")] public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [JsonProperty("POS_CashRegister")] public string POSCashRegister { get; set; }

        [JsonProperty("UpdateTime")] public string UpdateTime { get; set; }

        [JsonProperty("PriceMode")] public string PriceMode { get; set; }

        [JsonProperty("ShipFrom")] public string ShipFrom { get; set; }

        [JsonProperty("CommissionTrade")] public string CommissionTrade { get; set; }

        [JsonProperty("CommissionTradeReturn")] public string CommissionTradeReturn { get; set; }

        [JsonProperty("UseBillToAddrToDetermineTax")] public string UseBillToAddrToDetermineTax { get; set; }

        [JsonProperty("Cig")] public string Cig { get; set; }

        [JsonProperty("Cup")] public string Cup { get; set; }

        [JsonProperty("U_SMC_ESTADO_FE")] public string U_SMC_ESTADO_FE { get; set; }
        [JsonProperty("U_SMC_MSJ_ESTADO_EM")] public string U_SMC_MSJ_ESTADO_EM { get; set; }
        
        [JsonProperty("U_EXX_AIIR_EST")] public string U_EXX_AIIR_EST { get; set; }
        [JsonProperty("U_EXX_COVI")] public string U_EXX_COVI { get; set; }
        [JsonProperty("U_EXX_COTA")] public string U_EXX_COTA { get; set; }
        [JsonProperty("U_EXX_ESVI")] public string U_EXX_ESVI { get; set; }
        [JsonProperty("U_EXX_ESTA")] public string U_EXX_ESTA { get; set; }
        [JsonProperty("U_EXX_ESGU")] public string U_EXX_ESGU { get; set; }
        [JsonProperty("U_EXX_FRAG")] public string U_EXX_FRAG { get; set; }
        [JsonProperty("U_EXX_PREN")] public string U_EXX_PREN { get; set; }
        [JsonProperty("U_EXX_COEN")] public string U_EXX_COEN { get; set; }
        [JsonProperty("U_EXX_CORA")] public string U_EXX_CORA { get; set; }
        [JsonProperty("U_EXT_OSNRO")] public string U_EXT_OSNRO { get; set; }
        [JsonProperty("U_EXX_FE_PdfCreado")] public string U_EXX_FE_PdfCreado { get; set; }
        [JsonProperty("U_EXX_FE_MailEnviado")] public string U_EXX_FE_MailEnviado { get; set; }
        [JsonProperty("U_EXT_dc_fact_Dvta_IntegradoGas")] public string U_EXT_dc_fact_Dvta_IntegradoGas { get; set; }


        //[JsonProperty("U_BPV_SERI")] public string UBPVSERI { get; set; }

        //[JsonProperty("U_BPV_NCON2")] public string UBPVNCON2 { get; set; }

        //[JsonProperty("U_BPP_MDTD")] public string UBPPMDTD { get; set; }

        //[JsonProperty("U_OK1_Anulada")] public string UOK1Anulada { get; set; }

        //[JsonProperty("U_BPP_MDCT")] public string UBPPMDCT { get; set; }

        //[JsonProperty("U_BPP_MDNT")] public string UBPPMDNT { get; set; }

        //[JsonProperty("U_BPP_MDDT")] public string UBPPMDDT { get; set; }

        //[JsonProperty("U_BPP_MDRT")] public string UBPPMDRT { get; set; }

        //[JsonProperty("U_BPP_MDFC")] public string UBPPMDFC { get; set; }

        //[JsonProperty("U_BPP_MDFN")] public string UBPPMDFN { get; set; }

        //[JsonProperty("U_BPP_MDVC")] public string UBPPMDVC { get; set; }

        //[JsonProperty("U_BPP_MDVN")] public string UBPPMDVN { get; set; }

        //[JsonProperty("U_BPP_MDVT")] public string UBPPMDVT { get; set; }

        //[JsonProperty("U_BPP_MDMT")] public string UBPPMDMT { get; set; }

        //[JsonProperty("U_BPP_MDTS")] public string UBPPMDTS { get; set; }

        //[JsonProperty("U_BPP_CDAD")] public string UBPPCDAD { get; set; }

        //[JsonProperty("U_BPP_DPFC")] public string UBPPDPFC { get; set; }

        //[JsonProperty("U_BPP_DPNM")] public string UBPPDPNM { get; set; }

        //[JsonProperty("U_BPP_MDBI")] public string UBPPMDBI { get; set; }

        //[JsonProperty("U_BPP_MDCD")] public string UBPPMDCD { get; set; }

        //[JsonProperty("U_BPP_MDCO")] public string UBPPMDCO { get; set; }

        //[JsonProperty("U_BPP_MDFD")] public string UBPPMDFD { get; set; }

        //[JsonProperty("U_BPP_MDFE")] public string UBPPMDFE { get; set; }

        //[JsonProperty("U_BPP_MDND")] public string UBPPMDND { get; set; }

        //[JsonProperty("U_BPP_MDOM")] public string UBPPMDOM { get; set; }

        //[JsonProperty("U_BPP_MDSD")] public string UBPPMDSD { get; set; }

        //[JsonProperty("U_BPP_MDSN")] public string UBPPMDSN { get; set; }

        //[JsonProperty("U_BPP_MDSO")] public string UBPPMDSO { get; set; }

        //[JsonProperty("U_BPP_MDTO")] public string UBPPMDTO { get; set; }

        //[JsonProperty("U_BPP_SDOCDATE")] public string UBPPSDOCDATE { get; set; }

        //[JsonProperty("U_BPP_SND")] public string UBPPSND { get; set; }

        //[JsonProperty("U_VS_OCCLIENTE")] public string UVSOCCLIENTE { get; set; }

        //[JsonProperty("U_VS_NRO_GR")] public string UVSNROGR { get; set; }

        //[JsonProperty("U_VS_NRO_FT")] public string UVSNROFT { get; set; }

        //[JsonProperty("U_VS_FLGCOTIZA")] public string UVSFLGCOTIZA { get; set; }

        //[JsonProperty("U_VS_ANTAPL")] public string UVSANTAPL { get; set; }

        //[JsonProperty("U_VS_DOCORG")] public string UVSDOCORG { get; set; }

        //[JsonProperty("U_VS_SDOCTOTAL")] public double? UVSSDOCTOTAL { get; set; }

        //[JsonProperty("U_VS_USRSV")] public string UVSUSRSV { get; set; }

        //[JsonProperty("U_VS_TDOCORG")] public string UVSTDOCORG { get; set; }

        //[JsonProperty("U_VS_FRMSAP")] public string UVSFRMSAP { get; set; }

        //[JsonProperty("U_VS_REPDNI")] public string UVSREPDNI { get; set; }

        //[JsonProperty("U_VS_REPNOM")] public string UVSREPNOM { get; set; }

        //[JsonProperty("U_BPP_JrlDestino")] public string UBPPJrlDestino { get; set; }

        //[JsonProperty("U_VS_LINAFPRCP")] public string UVSLINAFPRCP { get; set; }

        //[JsonProperty("U_VS_METVAL")] public string UVSMETVAL { get; set; }

        //[JsonProperty("U_VS_INCPRCP")] public string UVSINCPRCP { get; set; }

        //[JsonProperty("U_VS_MOTEMI")] public string UVSMOTEMI { get; set; }

        //[JsonProperty("U_VS_SUSTNT")] public string UVSSUSTNT { get; set; }

        //[JsonProperty("U_VS_FESTAT")] public string UVSFESTAT { get; set; }

        //[JsonProperty("U_VS_CDRRSM")] public string UVSCDRRSM { get; set; }

        //[JsonProperty("U_VS_GRATEN")] public string UVSGRATEN { get; set; }

        //[JsonProperty("U_VS_GUITRA")] public string UVSGUITRA { get; set; }

        //[JsonProperty("U_VS_PORTSUNAT")] public string UVSPORTSUNAT { get; set; }

        //[JsonProperty("U_BPP_MDCI")] public string UBPPMDCI { get; set; }

        //[JsonProperty("U_BPP_MDCF")] public string UBPPMDCF { get; set; }

        //[JsonProperty("U_BPP_MDTL")] public string UBPPMDTL { get; set; }

        //[JsonProperty("U_LN_TIPOCAP")] public string ULNTIPOCAP { get; set; }

        //[JsonProperty("U_VS_CODSER")] public string UVSCODSER { get; set; }

        //[JsonProperty("U_VS_AFEDET")] public string UVSAFEDET { get; set; }

        //[JsonProperty("U_VS_PORDET")] public double? UVSPORDET { get; set; }

        //[JsonProperty("U_VS_APLANT")] public string UVSAPLANT { get; set; }

        //[JsonProperty("U_BPP_MDSD2")] public string UBPPMDSD2 { get; set; }

        //[JsonProperty("U_VS_MONDET")] public double? UVSMONDET { get; set; }

        //[JsonProperty("U_VS_NATNUM")] public string UVSNATNUM { get; set; }

        //[JsonProperty("U_VS_ANULGUIA")] public string UVSANULGUIA { get; set; }

        //[JsonProperty("U_NUMER")] public string UNUMER { get; set; }

        //[JsonProperty("U_NUMCC")] public string UNUMCC { get; set; }

        //[JsonProperty("U_VS_DEVENG")] public string UVSDEVENG { get; set; }

        //[JsonProperty("U_VS_TYDEV")] public string UVSTYDEV { get; set; }

        //[JsonProperty("U_VS_DIRLLEG")] public string UVSDIRLLEG { get; set; }

        //[JsonProperty("U_VS_GLNLLEG")] public string UVSGLNLLEG { get; set; }

        //[JsonProperty("U_VS_PBRTOTAL")] public double? UVSPBRTOTAL { get; set; }

        //[JsonProperty("U_VS_BULPAL")] public string UVSBULPAL { get; set; }

        //[JsonProperty("U_VS_CODPUER")] public string UVSCODPUER { get; set; }

        //[JsonProperty("U_VS_MOTTRAS")] public string UVSMOTTRAS { get; set; }

        //[JsonProperty("U_VS_DIRPART")] public string UVSDIRPART { get; set; }

        //[JsonProperty("U_VS_GLNPART")] public string UVSGLNPART { get; set; }

        //[JsonProperty("U_VS_MODTRA")] public string UVSMODTRA { get; set; }

        //[JsonProperty("U_VS_DOCCOND")] public string UVSDOCCOND { get; set; }

        //[JsonProperty("U_VS_CODTCOND")] public string UVSCODTCOND { get; set; }

        //[JsonProperty("U_VS_NUMCONT")] public string UVSNUMCONT { get; set; }

        //[JsonProperty("U_VS_INTRASB")] public string UVSINTRASB { get; set; }

        //[JsonProperty("U_VS_FECTRAS")] public string UVSFECTRAS { get; set; }

        //[JsonProperty("U_VS_HMDS")] public double? UVSHMDS { get; set; }

        //[JsonProperty("U_VS_TIPO_FACT")] public string UVSTIPOFACT { get; set; }

        //[JsonProperty("U_VS_MPAGO")] public string UVSMPAGO { get; set; }

        //[JsonProperty("U_VS_MTRCL")] public string UVSMTRCL { get; set; }

        //[JsonProperty("U_VS_NMEMB")] public string UVSNMEMB { get; set; }

        //[JsonProperty("U_VS_DESESPC")] public string UVSDESESPC { get; set; }

        //[JsonProperty("U_VS_LGDESC")] public string UVSLGDESC { get; set; }

        //[JsonProperty("U_VS_CNESPC")] public double? UVSCNESPC { get; set; }

        //[JsonProperty("U_VS_FECDESC")] public string UVSFECDESC { get; set; }

        //[JsonProperty("U_VS_DIGESTVALUE")] public string UVSDIGESTVALUE { get; set; }

        //[JsonProperty("U_VS_CODBARRA")] public string UVSCODBARRA { get; set; }

        //[JsonProperty("U_VS_ENVIO_SUNAT")] public string UVSENVIOSUNAT { get; set; }

        //[JsonProperty("U_VS_HPDS")] public double? UVSHPDS { get; set; }

        //[JsonProperty("U_VS_CLSBYS")] public string UVSCLSBYS { get; set; }

        //[JsonProperty("U_VS_IDBENF")] public string UVSIDBENF { get; set; }

        //[JsonProperty("U_VS_RZBENF")] public string UVSRZBENF { get; set; }

        //[JsonProperty("U_VS_PAISBF")] public string UVSPAISBF { get; set; }

        //[JsonProperty("U_VS_CONVEN")] public string UVSCONVEN { get; set; }

        //[JsonProperty("U_VS_EXONER")] public string UVSEXONER { get; set; }

        //[JsonProperty("U_VS_TIPREN")] public string UVSTIPREN { get; set; }

        //[JsonProperty("U_VS_MODSRV")] public string UVSMODSRV { get; set; }

        //[JsonProperty("U_VS_TIPCREF")] public string UVSTIPCREF { get; set; }

        //[JsonProperty("U_VS_SI")] public string UVSSI { get; set; }

        //[JsonProperty("U_CL_REFORIG")] public string UCLREFORIG { get; set; }



        [JsonProperty("Document_ApprovalRequests")] public List<object> DocumentApprovalRequests { get; set; }

        [JsonProperty("DocumentLines")] public List<OrderDocumentLine> DocumentLines { get; set; }

        [JsonProperty("ElectronicProtocols")] public List<object> ElectronicProtocols { get; set; }

        [JsonProperty("DocumentAdditionalExpenses")] public List<object> DocumentAdditionalExpenses { get; set; }

        [JsonProperty("WithholdingTaxDataWTXCollection")] public List<object> WithholdingTaxDataWTXCollection { get; set; }

        [JsonProperty("WithholdingTaxDataCollection")] public List<object> WithholdingTaxDataCollection { get; set; }

        [JsonProperty("DocumentSpecialLines")] public List<object> DocumentSpecialLines { get; set; }

        [JsonProperty("DocumentReferences")] public List<object> DocumentReferences { get; set; }
    }

    public class OrderLineTaxJurisdiction
    {
        [JsonProperty("JurisdictionCode")] public string JurisdictionCode { get; set; }

        [JsonProperty("JurisdictionType")] public int? JurisdictionType { get; set; }

        [JsonProperty("TaxAmount")] public double? TaxAmount { get; set; }

        [JsonProperty("TaxAmountSC")] public double? TaxAmountSC { get; set; }

        [JsonProperty("TaxAmountFC")] public double? TaxAmountFC { get; set; }

        [JsonProperty("TaxRate")] public double? TaxRate { get; set; }

        [JsonProperty("DocEntry")] public int? DocEntry { get; set; }

        [JsonProperty("LineNumber")] public int? LineNumber { get; set; }

        [JsonProperty("RowSequence")] public int? RowSequence { get; set; }

    }

    public class OrderDocumentLine
    {
        [JsonProperty("LineNum")] public int? LineNum { get; set; }

        [JsonProperty("ItemCode")] public string ItemCode { get; set; }
        [JsonProperty("ItemName")] public string ItemName { get; set; }

        [JsonProperty("ItemDescription")] public string ItemDescription { get; set; }

        [JsonProperty("Quantity")] public double Quantity { get; set; }

        [JsonProperty("ShipDate")] public string ShipDate { get; set; }

        [JsonProperty("Price")] public double? Price { get; set; }

        [JsonProperty("PriceAfterVAT")] public double? PriceAfterVAT { get; set; }

        [JsonProperty("Currency")] public string Currency { get; set; }

        [JsonProperty("Rate")] public double? Rate { get; set; }

        [JsonProperty("DiscountPercent")] public double? DiscountPercent { get; set; }

        [JsonProperty("VendorNum")] public string VendorNum { get; set; }

        [JsonProperty("SerialNum")] public string SerialNum { get; set; }

        [JsonProperty("WarehouseCode")] public string WarehouseCode { get; set; }

        [JsonProperty("SalesPersonCode")] public int? SalesPersonCode { get; set; }

        [JsonProperty("CommisionPercent")] public double? CommisionPercent { get; set; }

        [JsonProperty("TreeType")] public string TreeType { get; set; }

        [JsonProperty("AccountCode")] public string AccountCode { get; set; }

        [JsonProperty("UseBaseUnits")] public string UseBaseUnits { get; set; }

        [JsonProperty("SupplierCatNum")] public string SupplierCatNum { get; set; }

        [JsonProperty("CostingCode")] public string CostingCode { get; set; }

        [JsonProperty("ProjectCode")] public string ProjectCode { get; set; }

        [JsonProperty("BarCode")] public string BarCode { get; set; }

        [JsonProperty("VatGroup")] public string VatGroup { get; set; }

        [JsonProperty("Height1")] public double? Height1 { get; set; }

        [JsonProperty("Hight1Unit")] public string Hight1Unit { get; set; }

        [JsonProperty("Height2")] public double? Height2 { get; set; }

        [JsonProperty("Height2Unit")] public string Height2Unit { get; set; }

        [JsonProperty("Lengh1")] public double? Lengh1 { get; set; }

        [JsonProperty("Lengh1Unit")] public string Lengh1Unit { get; set; }

        [JsonProperty("Lengh2")] public double? Lengh2 { get; set; }

        [JsonProperty("Lengh2Unit")] public string Lengh2Unit { get; set; }

        [JsonProperty("Weight1")] public double? Weight1 { get; set; }

        [JsonProperty("Weight1Unit")] public string Weight1Unit { get; set; }

        [JsonProperty("Weight2")] public double? Weight2 { get; set; }

        [JsonProperty("Weight2Unit")] public string Weight2Unit { get; set; }

        [JsonProperty("Factor1")] public double? Factor1 { get; set; }

        [JsonProperty("Factor2")] public double? Factor2 { get; set; }

        [JsonProperty("Factor3")] public double? Factor3 { get; set; }

        [JsonProperty("Factor4")] public double? Factor4 { get; set; }

        [JsonProperty("BaseType")] public int? BaseType { get; set; }

        [JsonProperty("BaseEntry")] public string BaseEntry { get; set; }

        [JsonProperty("BaseLine")] public string BaseLine { get; set; }

        [JsonProperty("Volume")] public double? Volume { get; set; }

        [JsonProperty("VolumeUnit")] public int? VolumeUnit { get; set; }

        [JsonProperty("Width1")] public double? Width1 { get; set; }

        [JsonProperty("Width1Unit")] public string Width1Unit { get; set; }

        [JsonProperty("Width2")] public double? Width2 { get; set; }

        [JsonProperty("Width2Unit")] public string Width2Unit { get; set; }

        [JsonProperty("Address")] public string Address { get; set; }

        [JsonProperty("TaxCode")] public string TaxCode { get; set; }

        [JsonProperty("TaxType")] public string TaxType { get; set; }

        [JsonProperty("TaxLiable")] public string TaxLiable { get; set; }

        [JsonProperty("PickStatus")] public string PickStatus { get; set; }

        [JsonProperty("PickQuantity")] public double? PickQuantity { get; set; }

        [JsonProperty("PickListIdNumber")] public string PickListIdNumber { get; set; }

        [JsonProperty("OriginalItem")] public string OriginalItem { get; set; }

        [JsonProperty("BackOrder")] public string BackOrder { get; set; }

        [JsonProperty("FreeText")] public string FreeText { get; set; }

        [JsonProperty("ShippingMethod")] public int? ShippingMethod { get; set; }

        [JsonProperty("POTargetNum")] public string POTargetNum { get; set; }

        [JsonProperty("POTargetEntry")] public string POTargetEntry { get; set; }

        [JsonProperty("POTargetRowNum")] public string POTargetRowNum { get; set; }

        [JsonProperty("CorrectionInvoiceItem")] public string CorrectionInvoiceItem { get; set; }

        [JsonProperty("CorrInvAmountToStock")] public double? CorrInvAmountToStock { get; set; }

        [JsonProperty("CorrInvAmountToDiffAcct")] public double? CorrInvAmountToDiffAcct { get; set; }

        [JsonProperty("AppliedTax")] public double? AppliedTax { get; set; }

        [JsonProperty("AppliedTaxFC")] public double? AppliedTaxFC { get; set; }

        [JsonProperty("AppliedTaxSC")] public double? AppliedTaxSC { get; set; }

        [JsonProperty("WTLiable")] public string WTLiable { get; set; }

        [JsonProperty("DeferredTax")] public string DeferredTax { get; set; }

        [JsonProperty("EqualizationTaxPercent")] public double? EqualizationTaxPercent { get; set; }

        [JsonProperty("TotalEqualizationTax")] public double? TotalEqualizationTax { get; set; }

        [JsonProperty("TotalEqualizationTaxFC")] public double? TotalEqualizationTaxFC { get; set; }

        [JsonProperty("TotalEqualizationTaxSC")] public double? TotalEqualizationTaxSC { get; set; }

        [JsonProperty("NetTaxAmount")] public double? NetTaxAmount { get; set; }

        [JsonProperty("NetTaxAmountFC")] public double? NetTaxAmountFC { get; set; }

        [JsonProperty("NetTaxAmountSC")] public double? NetTaxAmountSC { get; set; }

        [JsonProperty("MeasureUnit")] public string MeasureUnit { get; set; }

        [JsonProperty("UnitsOfMeasurment")] public double? UnitsOfMeasurment { get; set; }

        [JsonProperty("LineTotal")] public double? LineTotal { get; set; }

        [JsonProperty("TaxPercentagePerRow")] public double? TaxPercentagePerRow { get; set; }

        [JsonProperty("TaxTotal")] public double? TaxTotal { get; set; }

        [JsonProperty("ConsumerSalesForecast")] public string ConsumerSalesForecast { get; set; }

        [JsonProperty("ExciseAmount")] public double? ExciseAmount { get; set; }

        [JsonProperty("TaxPerUnit")] public double? TaxPerUnit { get; set; }

        [JsonProperty("TotalInclTax")] public double? TotalInclTax { get; set; }

        [JsonProperty("CountryOrg")] public string CountryOrg { get; set; }

        [JsonProperty("SWW")] public string SWW { get; set; }

        [JsonProperty("TransactionType")] public string TransactionType { get; set; }

        [JsonProperty("DistributeExpense")] public string DistributeExpense { get; set; }

        [JsonProperty("RowTotalFC")] public double? RowTotalFC { get; set; }

        [JsonProperty("RowTotalSC")] public double? RowTotalSC { get; set; }

        [JsonProperty("LastBuyInmPrice")] public double? LastBuyInmPrice { get; set; }

        [JsonProperty("LastBuyDistributeSumFc")] public double? LastBuyDistributeSumFc { get; set; }

        [JsonProperty("LastBuyDistributeSumSc")] public double? LastBuyDistributeSumSc { get; set; }

        [JsonProperty("LastBuyDistributeSum")] public double? LastBuyDistributeSum { get; set; }

        [JsonProperty("StockDistributesumForeign")] public double? StockDistributesumForeign { get; set; }

        [JsonProperty("StockDistributesumSystem")] public double? StockDistributesumSystem { get; set; }

        [JsonProperty("StockDistributesum")] public double? StockDistributesum { get; set; }

        [JsonProperty("StockInmPrice")] public double? StockInmPrice { get; set; }

        [JsonProperty("PickStatusEx")] public string PickStatusEx { get; set; }

        [JsonProperty("TaxBeforeDPM")] public double? TaxBeforeDPM { get; set; }

        [JsonProperty("TaxBeforeDPMFC")] public double? TaxBeforeDPMFC { get; set; }

        [JsonProperty("TaxBeforeDPMSC")] public double? TaxBeforeDPMSC { get; set; }

        [JsonProperty("CFOPCode")] public string CFOPCode { get; set; }

        [JsonProperty("CSTCode")] public string CSTCode { get; set; }

        [JsonProperty("Usage")] public string Usage { get; set; }

        [JsonProperty("TaxOnly")] public string TaxOnly { get; set; }

        [JsonProperty("VisualOrder")] public int? VisualOrder { get; set; }

        [JsonProperty("BaseOpenQuantity")] public double? BaseOpenQuantity { get; set; }

        [JsonProperty("UnitPrice")] public double? UnitPrice { get; set; }

        [JsonProperty("LineStatus")] public string LineStatus { get; set; }

        [JsonProperty("PackageQuantity")] public double? PackageQuantity { get; set; }

        [JsonProperty("Text")] public string Text { get; set; }

        [JsonProperty("LineType")] public string LineType { get; set; }

        [JsonProperty("COGSCostingCode")] public string COGSCostingCode { get; set; }

        [JsonProperty("COGSAccountCode")] public string COGSAccountCode { get; set; }

        [JsonProperty("ChangeAssemlyBoMWarehouse")] public string ChangeAssemlyBoMWarehouse { get; set; }

        [JsonProperty("GrossBuyPrice")] public double? GrossBuyPrice { get; set; }

        [JsonProperty("GrossBase")] public string GrossBase { get; set; }

        [JsonProperty("GrossProfitTotalBasePrice")] public double? GrossProfitTotalBasePrice { get; set; }

        [JsonProperty("CostingCode2")] public string CostingCode2 { get; set; }

        [JsonProperty("CostingCode3")] public string CostingCode3 { get; set; }

        [JsonProperty("CostingCode4")] public string CostingCode4 { get; set; }

        [JsonProperty("CostingCode5")] public string CostingCode5 { get; set; }

        [JsonProperty("ItemDetails")] public string ItemDetails { get; set; }

        [JsonProperty("LocationCode")] public string LocationCode { get; set; }

        [JsonProperty("ActualDeliveryDate")] public string ActualDeliveryDate { get; set; }

        [JsonProperty("RemainingOpenQuantity")] public double? RemainingOpenQuantity { get; set; }

        [JsonProperty("OpenAmount")] public double? OpenAmount { get; set; }

        [JsonProperty("OpenAmountFC")] public double? OpenAmountFC { get; set; }

        [JsonProperty("OpenAmountSC")] public double? OpenAmountSC { get; set; }

        [JsonProperty("ExLineNo")] public string ExLineNo { get; set; }

        [JsonProperty("RequiredDate")] public string RequiredDate { get; set; }

        [JsonProperty("RequiredQuantity")] public double? RequiredQuantity { get; set; }

        [JsonProperty("COGSCostingCode2")] public string COGSCostingCode2 { get; set; }

        [JsonProperty("COGSCostingCode3")] public string COGSCostingCode3 { get; set; }

        [JsonProperty("COGSCostingCode4")] public string COGSCostingCode4 { get; set; }

        [JsonProperty("COGSCostingCode5")] public string COGSCostingCode5 { get; set; }

        [JsonProperty("CSTforIPI")] public string CSTforIPI { get; set; }

        [JsonProperty("CSTforPIS")] public string CSTforPIS { get; set; }

        [JsonProperty("CSTforCOFINS")] public string CSTforCOFINS { get; set; }

        [JsonProperty("CreditOriginCode")] public string CreditOriginCode { get; set; }

        [JsonProperty("WithoutInventoryMovement")] public string WithoutInventoryMovement { get; set; }

        [JsonProperty("AgreementNo")] public string AgreementNo { get; set; }

        [JsonProperty("AgreementRowNumber")] public string AgreementRowNumber { get; set; }

        [JsonProperty("ActualBaseEntry")] public string ActualBaseEntry { get; set; }

        [JsonProperty("ActualBaseLine")] public string ActualBaseLine { get; set; }

        [JsonProperty("DocEntry")] public int? DocEntry { get; set; }

        [JsonProperty("Surpluses")] public double? Surpluses { get; set; }

        [JsonProperty("DefectAndBreakup")] public double? DefectAndBreakup { get; set; }

        [JsonProperty("Shortages")] public double? Shortages { get; set; }

        [JsonProperty("ConsiderQuantity")] public string ConsiderQuantity { get; set; }

        [JsonProperty("PartialRetirement")] public string PartialRetirement { get; set; }

        [JsonProperty("RetirementQuantity")] public double? RetirementQuantity { get; set; }

        [JsonProperty("RetirementAPC")] public double? RetirementAPC { get; set; }

        [JsonProperty("ThirdParty")] public string ThirdParty { get; set; }

        [JsonProperty("ExpenseType")] public string ExpenseType { get; set; }

        [JsonProperty("ReceiptNumber")] public string ReceiptNumber { get; set; }

        [JsonProperty("ExpenseOperationType")] public string ExpenseOperationType { get; set; }

        [JsonProperty("FederalTaxID")] public string FederalTaxID { get; set; }

        [JsonProperty("StgSeqNum")] public string StgSeqNum { get; set; }

        [JsonProperty("StgEntry")] public string StgEntry { get; set; }

        [JsonProperty("StgDesc")] public string StgDesc { get; set; }

        [JsonProperty("UoMEntry")] public int? UoMEntry { get; set; }

        [JsonProperty("UoMCode")] public string UoMCode { get; set; }

        [JsonProperty("InventoryQuantity")] public double? InventoryQuantity { get; set; }

        [JsonProperty("RemainingOpenInventoryQuantity")] public double? RemainingOpenInventoryQuantity { get; set; }

        [JsonProperty("ParentLineNum")] public string ParentLineNum { get; set; }

        [JsonProperty("Incoterms")] public int? Incoterms { get; set; }

        [JsonProperty("TransportMode")] public int? TransportMode { get; set; }

        [JsonProperty("ItemType")] public string ItemType { get; set; }

        [JsonProperty("ChangeInventoryQuantityIndependently")] public string ChangeInventoryQuantityIndependently { get; set; }

        [JsonProperty("FreeOfChargeBP")] public string FreeOfChargeBP { get; set; }

        [JsonProperty("SACEntry")] public string SACEntry { get; set; }

        [JsonProperty("HSNEntry")] public string HSNEntry { get; set; }

        [JsonProperty("GrossPrice")] public double? GrossPrice { get; set; }

        [JsonProperty("GrossTotal")] public double? GrossTotal { get; set; }

        [JsonProperty("GrossTotalFC")] public double? GrossTotalFC { get; set; }

        [JsonProperty("GrossTotalSC")] public double? GrossTotalSC { get; set; }

        [JsonProperty("NCMCode")] public int? NCMCode { get; set; }

        [JsonProperty("ShipFromCode")] public string ShipFromCode { get; set; }

        [JsonProperty("ShipFromDescription")] public string ShipFromDescription { get; set; }

        //[JsonProperty("U_BPP_CTAD")] public string UBPPCTAD { get; set; }

        //[JsonProperty("U_BPP_OPER")] public string UBPPOPER { get; set; }

        //[JsonProperty("U_tipoOpT12")] public string UTipoOpT12 { get; set; }

        //[JsonProperty("U_VS_DISPSTK")] public string UVSDISPSTK { get; set; }

        //[JsonProperty("U_VS_SERDOC")] public string UVSSERDOC { get; set; }

        //[JsonProperty("U_VS_FECEMI")] public string UVSFECEMI { get; set; }

        //[JsonProperty("U_VS_TIPDOC")] public string UVSTIPDOC { get; set; }

        //[JsonProperty("U_VS_CDMMOV")] public string UVSCDMMOV { get; set; }

        //[JsonProperty("U_VS_MOTMOV")] public string UVSMOTMOV { get; set; }

        //[JsonProperty("U_VS_TIPSAP")] public string UVSTIPSAP { get; set; }

        //[JsonProperty("U_VS_DOCSAP")] public string UVSDOCSAP { get; set; }

        //[JsonProperty("U_VS_DOCNUM")] public string UVSDOCNUM { get; set; }

        //[JsonProperty("U_VS_MNTPRCP")] public double? UVSMNTPRCP { get; set; }

        //[JsonProperty("U_VS_MNTCBRD")] public double? UVSMNTCBRD { get; set; }

        //[JsonProperty("U_VS_CODPRCP")] public string UVSCODPRCP { get; set; }

        //[JsonProperty("U_VS_GRPPRCP")] public string UVSGRPPRCP { get; set; }

        //[JsonProperty("U_VS_DOCSI")] public string UVSDOCSI { get; set; }

        //[JsonProperty("U_VS_DOCTOTAL")] public double? UVSDOCTOTAL { get; set; }

        //[JsonProperty("U_VS_ONEROSO")] public string UVSONEROSO { get; set; }

        //[JsonProperty("U_VS_TIPISC")] public string UVSTIPISC { get; set; }

        //[JsonProperty("U_VS_TIPAFE")] public string UVSTIPAFE { get; set; }

        //[JsonProperty("U_VS_T12IN")] public string UVST12IN { get; set; }

        //[JsonProperty("U_VS_GLNORG")] public string UVSGLNORG { get; set; }

        //[JsonProperty("U_VS_DIRORG")] public string UVSDIRORG { get; set; }

        //[JsonProperty("U_VS_GLNDEST")] public string UVSGLNDEST { get; set; }

        //[JsonProperty("U_VS_DIRDEST")] public string UVSDIRDEST { get; set; }

        //[JsonProperty("U_VS_DTVIAJE")] public string UVSDTVIAJE { get; set; }

        //[JsonProperty("U_VS_VLTRANS")] public string UVSVLTRANS { get; set; }

        //[JsonProperty("U_VS_VLEFEC")] public string UVSVLEFEC { get; set; }

        //[JsonProperty("U_VS_VLUTIL")] public string UVSVLUTIL { get; set; }

        //[JsonProperty("U_VS_CONFVEH")] public string UVSCONFVEH { get; set; }

        //[JsonProperty("U_VS_CGUTMS")] public string UVSCGUTMS { get; set; }

        //[JsonProperty("U_VS_CGEFEMS")] public string UVSCGEFEMS { get; set; }

        //[JsonProperty("U_VS_VLTM")] public string UVSVLTM { get; set; }

        //[JsonProperty("U_VS_VLCGUTL")] public string UVSVLCGUTL { get; set; }

        //[JsonProperty("U_VS_FCTRET")] public string UVSFCTRET { get; set; }

        //[JsonProperty("U_VS_PRCREF")] public string UVSPRCREF { get; set; }

        //[JsonProperty("U_VS_HIMPC")] public double? UVSHIMPC { get; set; }

        //[JsonProperty("U_VS_HIMPS")] public double? UVSHIMPS { get; set; }

        //[JsonProperty("U_VS_DOCTRM")] public string UVSDOCTRM { get; set; }

        //[JsonProperty("U_VS_IT_CODEXT")] public string UVSITCODEXT { get; set; }

        //[JsonProperty("U_VS_IT_LINEXT")] public string UVSITLINEXT { get; set; }


        [JsonProperty("DocumentLineAdditionalExpenses")] public List<object> DocumentLineAdditionalExpenses { get; set; }

        [JsonProperty("WithholdingTaxLines")] public List<object> WithholdingTaxLines { get; set; }

        [JsonProperty("SerialNumbers")] public List<object> SerialNumbers { get; set; }

        [JsonProperty("BatchNumbers")] public List<object> BatchNumbers { get; set; }

        [JsonProperty("DocumentLinesBinAllocations")] public List<object> DocumentLinesBinAllocations { get; set; }
    }
}