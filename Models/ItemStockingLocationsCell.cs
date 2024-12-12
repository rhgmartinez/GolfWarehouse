namespace Golf_Warehouse_WebAPI.Models
{
    /// <summary>
    /// Represents an item stocking locations cell.
    /// </summary>
    public class ItemStockingLocationsCell
    {
        public string ItemNo { get; set; }
        public string LocationId { get; set; }
        public string Dim1Upr { get; set; }
        public string Dim2Upr { get; set; }
        public string Dim3Upr { get; set; }
        public int MinQty { get; set; }
        public int MaxQty { get; set; }
        public int QtyCommitted { get; set; }
        public int QtyOnHand { get; set; }
        public int QtyAvailable => QtyOnHand - QtyCommitted;
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemStockingLocationsCell"/> class.
        /// </summary>
        public ItemStockingLocationsCell()
        {
        }

        public ItemStockingLocationsCell(string itemNo, string locationId, string dim1Upr, string dim2Upr, string dim3Upr, int minQty, int maxQty, int qtyCommitted, int qtyOnHand, DateTime? lastMaintenanceDate, string lastMaintenanceUserId)
        {
            ItemNo = itemNo;
            LocationId = locationId;
            Dim1Upr = dim1Upr;
            Dim2Upr = dim2Upr;
            Dim3Upr = dim3Upr;
            MinQty = minQty;
            MaxQty = maxQty;
            QtyCommitted = qtyCommitted;
            QtyOnHand = qtyOnHand;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceUserId = lastMaintenanceUserId;
        }
    }
}
