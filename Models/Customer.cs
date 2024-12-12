namespace Golf_Warehouse_WebAPI.Models
{
    public class Customer
    {
        public required string CustomerNumber { get; set; } // CUST_NO
        public required string Name { get; set; } // NAM
        public string FirstName { get; set; } // FST_NAM
        public string LastName { get; set; } // LST_NAM
        public string Address1 { get; set; } // ADRS_1
        public string Address2 { get; set; } // ADRS_2
        public string Address3 { get; set; } // ADRS_3
        public string City { get; set; } // CITY
        public string State { get; set; } // STATE
        public string ZipCode { get; set; } // ZIP_COD
        public string Country { get; set; } // CNTRY
        public string Phone { get; set; } // PHONE
        public string Contact { get; set; } // CONTCT
        public string EmailAddress { get; set; } // EMAIL_ADRS
        public required string StoreId { get; set; } // STR_ID
        public string Comment { get; set; } // COMMNT
        public required int NumberOfTransactions { get; set; } // NO_OF_TRANSACTIONS
        public DateTime? FirstSaleDate { get; set; } // FST_SAL_DAT
        public DateTime? LastSaleDate { get; set; } // LST_SAL_DAT
        public decimal? LastSaleAmount { get; set; } // LST_SAL_AMT
        public DateTime? LastMaintenanceDate { get; set; } // LST_MAINT_DT
        public string? LastMaintenanceUserId { get; set; } // LST_MAINT_USR_ID
    }
}
