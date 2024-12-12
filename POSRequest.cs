namespace Golf_Warehouse_WebAPI
{
    public class POSRequest
    {
        public int CustomerId { get; set; }
        public List<POSLineItemRequest> LineItems { get; set; }
    }
    public class POSLineItemRequest
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}
