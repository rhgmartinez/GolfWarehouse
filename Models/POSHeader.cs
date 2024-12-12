namespace Golf_Warehouse_WebAPI.Models
{
    public class POSHeader
    {
        public int DocumentId { get; set; }
        public string StoreId { get; set; }
        public string StationId { get; set; }
        public string DrawerId { get; set; }
        public int? DrawerSessionId { get; set; }
        public string TicketNumber { get; set; }
        public string DocumentType { get; set; }
        public string CustomerNumber { get; set; }
        public int? Lines { get; set; }
        public decimal LineTotal { get; set; }
        public string TaxCode { get; set; }
        public string CustomerPONumber { get; set; }
        public string SalesRepresentative { get; set; }
        public string StockLocationId { get; set; }
        public string PriceLocationId { get; set; }
        public string ProfitCenter { get; set; }
        public string VoidUserId { get; set; }
        public string VoidReason { get; set; }
        public string TaxExemptNumber { get; set; }
        public string TaxOverrideReason { get; set; }
        public Guid DocumentGuid { get; set; }
        public byte? BillToContactId { get; set; }
        public byte? ShipToContactId { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ErrorReference { get; set; }
        public DateTime? TicketDate { get; set; }
        public string NormalTaxCode { get; set; }
        public string Reference { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }
    }
}
