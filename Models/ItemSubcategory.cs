namespace Golf_Warehouse_WebAPI.Models
{
    public class ItemSubcategory
    {
        public string SubcategoryCode { get; set; }
        public string CategoryCode { get; set; }
        public string Description { get; set; }
        public string ProfitCenter { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public string LastMaintenanceUserId { get; set; }
        public decimal? MinimumProfitPercentage { get; set; }
        public decimal? TargetProfitPercentage { get; set; }
    }
}
