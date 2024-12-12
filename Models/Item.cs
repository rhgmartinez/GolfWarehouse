namespace Golf_Warehouse_WebAPI.Models
{    public class Item
    {
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public ItemType ItemType { get; set; }
        public string CategoryCode { get; set; }
        public string SubCategoryCode { get; set; }
        public TrackingMethod TrackingMethod { get; set; }
        public Status Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public bool IsTaxable { get; set; }
        public int QuantityDecimals { get; set; }
        public int PriceDecimals { get; set; }
        public string StockUnit { get; set; }
        public string VendorNo { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Cube { get; set; }
        public bool IsWeighed { get; set; }
        public PreferredUnit PreferredUnit { get; set; }
        public string CellBarcodePrefix { get; set; }
        public int? NextCellBarcodeNo { get; set; }
        public decimal Price1 { get; set; }
        public string Barcode { get; set; }

        // Enumerations for ItemType, TrackingMethod, Status, and PreferredUnit
        public enum ItemType
        {
            // Add values as needed
        }

        public enum TrackingMethod
        {
            // Add values as needed
        }

        public enum Status
        {
            // Add values as needed
        }

        public enum PreferredUnit
        {
            // Add values as needed
        }
    }
}
