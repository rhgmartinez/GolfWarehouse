namespace Golf_Warehouse_WebAPI.Models
{
    public class ItemStockingLocationValue
    {
        public string ItemNumber { get; set; }
        public string LocationId { get; set; }
        public string Bin { get; set; }
        public int MinimumQuantity { get; set; }
        public int MaximumQuantity { get; set; }
        public int QuantityCommitted { get; set; }
        public int QuantityOnHand { get; set; }
        public decimal GrossValue { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }

        public ItemStockingLocationValue()
        {
        }

        public ItemStockingLocationValue(string itemNumber, string locationId, string bin, int minimumQuantity, int maximumQuantity, int quantityCommitted, int quantityOnHand, decimal grossValue, DateTime? lastMaintenanceDate, string lastMaintenanceUserId)
        {
            ItemNumber = itemNumber;
            LocationId = locationId;
            Bin = bin;
            MinimumQuantity = minimumQuantity;
            MaximumQuantity = maximumQuantity;
            QuantityCommitted = quantityCommitted;
            QuantityOnHand = quantityOnHand;
            GrossValue = grossValue;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceUserId = lastMaintenanceUserId;
        }

        public override string ToString()
        {
            return $"Item Stocking Location Value - {ItemNumber} at {LocationId}: {QuantityOnHand} units";
        }

        public int GetQuantityAvailable()
        {
            return QuantityOnHand - QuantityCommitted;
        }

        public decimal GetAverageCost()
        {
            if (QuantityOnHand > 0 && GrossValue >= 0)
            {
                return GrossValue / QuantityOnHand;
            }
            else
            {
                return 0;
            }
        }
    }
}
