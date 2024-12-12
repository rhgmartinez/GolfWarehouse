namespace Golf_Warehouse_WebAPI.Models
{
    public class POSPayment
    {
        public string DocumentId { get; set; }
        public int PaymentSequenceNumber { get; set; }
        public string CardNumber { get; set; }
        public string PaymentCodeType { get; set; }
        public decimal Amount { get; set; }
        public string StoreId { get; set; }
        public bool IsFinalPayment { get; set; }
        public string StationId { get; set; }
        public bool IsCardNew { get; set; }
        public string TicketNumber { get; set; }
        public bool IsSecureEcommTransaction { get; set; }
        public string PaymentLineType { get; set; }
        public string PaymentCode { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool IsDepLineCopiedToRelDoc { get; set; }
        public decimal HomeCurrencyAmount { get; set; }
        public decimal ExchangeLoss { get; set; }
        public byte[] SignatureImage { get; set; }
        public bool IsSwiped { get; set; }
        public byte[] SignatureImageVector { get; set; }
        public string EDCAuthorizationCode { get; set; }
        public string Description { get; set; }
        public string EDCAuthorizationFlag { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? EBTBalanceRemaining { get; set; }
        public decimal ExchangeRateNumerator { get; set; }
        public decimal ExchangeRateDenominator { get; set; }
        public decimal? LoyaltyPointsRedeemed { get; set; }
        public decimal? ServiceBalanceRemaining { get; set; }
        public string ServiceReferenceNumber { get; set; }
        public string EDCAuthorizationResponse { get; set; }
        public decimal RoundGainLoss { get; set; }
        public decimal HomeCurrencyRoundGainLoss { get; set; }
        public decimal TipAmount { get; set; }
        public bool IsGFCAuthorized { get; set; }

        public POSPayment()
        {
        }

        public POSPayment(string documentId, int paymentSequenceNumber, string cardNumber, string paymentCodeType, decimal amount, string storeId, bool isFinalPayment, string stationId, bool isCardNew, string ticketNumber, bool isSecureEcommTransaction, string paymentLineType, string paymentCode, DateTime? paymentDate, bool isDepLineCopiedToRelDoc, decimal homeCurrencyAmount, decimal exchangeLoss, byte[] signatureImage, bool isSwiped, byte[] signatureImageVector, string edcAuthorizationCode, string description, string edcAuthorizationFlag, string currencyCode, decimal? ebtBalanceRemaining, decimal exchangeRateNumerator, decimal exchangeRateDenominator, decimal? loyaltyPointsRedeemed, decimal? serviceBalanceRemaining, string serviceReferenceNumber, string edcAuthorizationResponse, decimal roundGainLoss, decimal homeCurrencyRoundGainLoss, decimal tipAmount, bool isGFCAuthorized)
        {
            DocumentId = documentId;
            PaymentSequenceNumber = paymentSequenceNumber;
            CardNumber = cardNumber;
            PaymentCodeType = paymentCodeType;
            Amount = amount;
            StoreId = storeId;
            IsFinalPayment = isFinalPayment;
            StationId = stationId;
            IsCardNew = isCardNew;
            TicketNumber = ticketNumber;
            IsSecureEcommTransaction = isSecureEcommTransaction;
            PaymentLineType = paymentLineType;
            PaymentCode = paymentCode;
            PaymentDate = paymentDate;
            IsDepLineCopiedToRelDoc = isDepLineCopiedToRelDoc;
            HomeCurrencyAmount = homeCurrencyAmount;
            ExchangeLoss = exchangeLoss;
            SignatureImage = signatureImage;
            IsSwiped = isSwiped;
            SignatureImageVector = signatureImageVector;
            EDCAuthorizationCode = edcAuthorizationCode;
            Description = description;
            EDCAuthorizationFlag = edcAuthorizationFlag;
            CurrencyCode = currencyCode;
            EBTBalanceRemaining = ebtBalanceRemaining;
            ExchangeRateNumerator = exchangeRateNumerator;
            ExchangeRateDenominator = exchangeRateDenominator;
            LoyaltyPointsRedeemed = loyaltyPointsRedeemed;
            ServiceBalanceRemaining = serviceBalanceRemaining;
            ServiceReferenceNumber = serviceReferenceNumber;
            EDCAuthorizationResponse = edcAuthorizationResponse;
            RoundGainLoss = roundGainLoss;
            HomeCurrencyRoundGainLoss = homeCurrencyRoundGainLoss;
            TipAmount = tipAmount;
            IsGFCAuthorized = isGFCAuthorized;
        }

        public override string ToString()
        {
            return $"POS Payment - {DocumentId}: {Amount} {CurrencyCode}";
        }

        public decimal CalculateTotal()
        {
            return Amount;
        }
    }
}
