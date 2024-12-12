namespace Golf_Warehouse_WebAPI.Models
{
    public class ItemStockingLocation
    {
        public string LocationId { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Contact { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }

        public ItemStockingLocation()
        {
        }

        public ItemStockingLocation(string locationId, string description, string address1, string address2, string address3, string city, string state, string zipCode, string country, string phone, string contact, string emailAddress, DateTime? lastMaintenanceDate, string lastMaintenanceUserId)
        {
            LocationId = locationId;
            Description = description;
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            Phone = phone;
            Contact = contact;
            EmailAddress = emailAddress;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceUserId = lastMaintenanceUserId;
        }

        public override string ToString()
        {
            return $"Item Stocking Location - {LocationId}: {Description}";
        }

        public string GetFullAddress()
        {
            return $"{Address1} {Address2} {Address3} {City} {State} {ZipCode} {Country}";
        }
    }
}
