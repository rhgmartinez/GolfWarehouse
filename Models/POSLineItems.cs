using static Golf_Warehouse_WebAPI.Models.Item;

namespace Golf_Warehouse_WebAPI.Models
{
    public class POSLineItem
    {
        public string DocumentId { get; set; }
        public int LineSequenceNumber { get; set; }
        public string StoreId { get; set; }
        public string StationId { get; set; }
        public string TicketNumber { get; set; }
        public string LineType { get; set; }
        public decimal? Price { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public decimal? RetailValue { get; set; }
        public decimal? CalculatedPrice { get; set; }
        public decimal? ExtendedCost { get; set; }
        public string StockLocationId { get; set; }
        public decimal? RegularPrice { get; set; }
        public string PriceLocationId { get; set; }
        public string CategoryCode { get; set; }
        public string SubcategoryCode { get; set; }
        public string ItemVendorNumber { get; set; }
        public int QuantitySold { get; set; }
        public int QuantityNumerator { get; set; }
        public int QuantityDenominator { get; set; }
        public string QuantityUnit { get; set; }
        public string SellUnit { get; set; }
        public string ReturnReason { get; set; }
        public decimal ExtendedPrice { get; set; }
        public bool IsTaxable { get; set; }
        public string SalesRepresentative { get; set; }
        public string Reference { get; set; }
        public string ItemType { get; set; }
        public decimal? Price1 { get; set; }
        public int? QuantityDecimals { get; set; }
        public int? PriceDecimals { get; set; }
        public string Barcode { get; set; }
        public string TaxCategory { get; set; }
        public string TrackingMethod { get; set; }
        public decimal? UnitWeight { get; set; }
        public decimal? UnitCube { get; set; }
        public Guid LineGuid { get; set; }
        public string Dimension1Upper { get; set; }
        public string Dimension2Upper { get; set; }
        public string Dimension3Upper { get; set; }
        public decimal? UnitCost { get; set; }
        public string SerialNumber { get; set; }
        public int QuantityReturned { get; set; }
        public decimal GrossExtendedPrice { get; set; }
        public decimal? DisplayExtendedPrice { get; set; }
        public bool HasPriceOverride { get; set; }
        public string PriceOverrideReason { get; set; }
        public decimal? CostOfSalesPercentage { get; set; }
        public string MixMatchCode { get; set; }
        public bool UserEnteredPrice { get; set; }
        public decimal? GrossDisplayExtendedPrice { get; set; }
        public bool IsDiscountable { get; set; }
        public decimal CalculatedExtendedPrice { get; set; }
        public bool IsWeighed { get; set; }
        public decimal TaxAmountAllocated { get; set; }
        public decimal NormalTaxAmountAllocated { get; set; }

        public POSLineItem()
        {
        }

        public POSLineItem(string documentId, int lineSequenceNumber, string storeId, string stationId, string ticketNumber, string lineType, decimal? price, string itemNumber, string description, decimal? retailValue, decimal? calculatedPrice, decimal? extendedCost, string stockLocationId, decimal? regularPrice, string priceLocationId, string categoryCode, string subcategoryCode, string itemVendorNumber, int quantitySold, int quantityNumerator, int quantityDenominator, string quantityUnit, string sellUnit,
            string returnReason, decimal extendedPrice, bool isTaxable, string salesRepresentative, string reference, string itemType, decimal? price1, int? quantityDecimals, int? priceDecimals, string barcode, string taxCategory, string trackingMethod, decimal? unitWeight, decimal? unitCube, Guid lineGuid, string dimension1Upper, string dimension2Upper, string dimension3Upper, decimal? unitCost, string serialNumber, int quantityReturned, decimal grossExtendedPrice, decimal? displayExtendedPrice, bool hasPriceOverride, string priceOverrideReason, decimal? costOfSalesPercentage, string mixMatchCode, bool userEnteredPrice, decimal? grossDisplayExtendedPrice, bool isDiscountable, decimal calculatedExtendedPrice, bool isWeighed, decimal taxAmountAllocated, decimal normalTaxAmountAllocated
            )
        {
            DocumentId = documentId;
            LineSequenceNumber = lineSequenceNumber;
            StoreId = storeId;
            StationId = stationId;
            TicketNumber = ticketNumber;
            LineType = lineType;
            Price = price;
            ItemNumber = itemNumber;
            Description = description;
            RetailValue = retailValue;
            CalculatedPrice = calculatedPrice;
            ExtendedCost = extendedCost;
            StockLocationId = stockLocationId;
            RegularPrice = regularPrice;
            PriceLocationId = priceLocationId;
            CategoryCode = categoryCode;
            SubcategoryCode = subcategoryCode;
            ItemVendorNumber = itemVendorNumber;
            QuantitySold = quantitySold;
            QuantityNumerator = quantityNumerator;
            QuantityDenominator = quantityDenominator;
            QuantityUnit = quantityUnit;
            SellUnit = sellUnit;
            ReturnReason = returnReason;
            ExtendedPrice = extendedPrice;
            IsTaxable = isTaxable;
            SalesRepresentative = salesRepresentative;
            Reference = reference;
            ItemType = itemType;
            Price1 = price1;
            QuantityDecimals = quantityDecimals;
            PriceDecimals = priceDecimals;
            Barcode = barcode;
            TaxCategory = taxCategory;
            TrackingMethod = trackingMethod;
            UnitWeight = unitWeight;
            UnitCube = unitCube;
            LineGuid = lineGuid;
            Dimension1Upper = dimension1Upper;
            Dimension2Upper = dimension2Upper;
            Dimension3Upper = dimension3Upper;
            UnitCost = unitCost;
            SerialNumber = serialNumber;
            QuantityReturned = quantityReturned;
            GrossExtendedPrice = grossExtendedPrice;
            DisplayExtendedPrice = displayExtendedPrice;
            HasPriceOverride = hasPriceOverride;
            PriceOverrideReason = priceOverrideReason;
            CostOfSalesPercentage = costOfSalesPercentage;
            MixMatchCode = mixMatchCode;
            UserEnteredPrice = userEnteredPrice;
            GrossDisplayExtendedPrice = grossDisplayExtendedPrice;
            IsDiscountable = isDiscountable;
            CalculatedExtendedPrice = calculatedExtendedPrice;
            IsWeighed = isWeighed;
            TaxAmountAllocated = taxAmountAllocated;
            NormalTaxAmountAllocated = normalTaxAmountAllocated;
        }

        public decimal CalculateTotal()
        {
            return QuantitySold * (Price ?? 0);
        }
    }
}
