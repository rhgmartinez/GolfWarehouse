namespace Golf_Warehouse_WebAPI.Models
{
    /// <summary>
    /// Represents an item barcode.
    /// </summary>
    public class ItemBarcode
    {
        public string ItemNo { get; set; }
        public string Dim1Upr { get; set; }
        public string Dim2Upr { get; set; }
        public string Dim3Upr { get; set; }
        public string Barcode { get; set; }
        public string Unit { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }

        public int SequenceNo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBarcode"/> class.
        /// </summary>
        public ItemBarcode()
        {
        }

        public ItemBarcode(string itemNo, string dim1Upr, string dim2Upr, string dim3Upr, string barcode, string unit, DateTime? lastMaintenanceDate, string lastMaintenanceUserId, int sequenceNo)
        {
            ItemNo = itemNo;
            Dim1Upr = dim1Upr;
            Dim2Upr = dim2Upr;
            Dim3Upr = dim3Upr;
            Barcode = barcode;
            Unit = unit;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceUserId = lastMaintenanceUserId;
            SequenceNo = sequenceNo;
        }
    }
}
