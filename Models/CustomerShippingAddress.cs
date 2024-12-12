using System;

namespace Golf_Warehouse_WebAPI.Models
{
    public class CustomerShippingAddress
    {
        public string CustomerNo { get; set; }
        public string ShippingAddressId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPerson { get; set; }
        public string EmailAddress { get; set; }
        public string Comments { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingAddress"/> class.
        /// </summary>
        public CustomerShippingAddress()
        {
        }
        public CustomerShippingAddress(string customerNo, string shippingAddressId, string companyName, string firstName, string lastName, string addressLine1, string addressLine2, string addressLine3, string city, string state, string zipCode, string country, string phoneNumber, string contactPerson, string emailAddress, string comments, DateTime? lastMaintenanceDate, string lastMaintenanceUserId)
        {
            CustomerNo = customerNo;
            ShippingAddressId = shippingAddressId;
            CompanyName = companyName;
            FirstName = firstName;
            LastName = lastName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            PhoneNumber = phoneNumber;
            ContactPerson = contactPerson;
            EmailAddress = emailAddress;
            Comments = comments;
            LastMaintenanceDate = lastMaintenanceDate;
            LastMaintenanceUserId = lastMaintenanceUserId;
        }
    }
}
