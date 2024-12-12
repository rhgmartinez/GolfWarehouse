namespace Golf_Warehouse_WebAPI.Models
{
    /// <summary>
    /// Represents an item serial number.
    /// </summary>
    public class ItemSerialNumber
    {
        public string ItemNo { get; set; }
        public string SerialNo { get; set; }
        public string LocationId { get; set; }
        public string Status { get; set; }
        public decimal? SerialCost { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string VendorNo { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSerialNumber"/> class.
        /// </summary>
        public ItemSerialNumber()
        {
        }

        public ItemSerialNumber(string itemNo, string serialNo, string locationId, string status, decimal? serialCost, DateTime? receiveDate, string vendorNo, DateTime? lastMaintenanceDate, string lastMaintenanceUserId)
        {
            ItemNo = itemNo;
            SerialNo = serialNo;
            LocationId = locationId;
            Status = status;
            SerialCost = serialCost;
            ReceiveDate = receiveDate;
            VendorNo = vendorNo;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceUserId = lastMaintenanceUserId;
        }
    }
}
