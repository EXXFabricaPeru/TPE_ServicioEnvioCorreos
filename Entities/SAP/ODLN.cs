using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    [SAPEntityName("DeliveryNotes")]
    public class ODLN
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
}