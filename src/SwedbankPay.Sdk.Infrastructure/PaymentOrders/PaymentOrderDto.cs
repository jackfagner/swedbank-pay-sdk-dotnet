using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentOrderDto
    {
        public string Id { get; set; }
        public long Amount { get; set; }
        public long VatAmount { get; set; }
        public DateTime Created { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public MetadataDto Metadata { get; set; }
        public string Operation { get; set; }
        public OrderItemListResponseDto OrderItems { get; set; }
        public int RemainingCancelAmount { get; set; }
        public int RemainingCaptureAmount { get; set; }
        public int RemainingReversalAmount { get; set; }
        public Identifiable Settings { get; set; }
        public string State { get; set; }
        public DateTime Updated { get; set; }
        public UrlsDto Urls { get; set; }
        public string UserAgent { get; set; }
        public string InitiatingSystemUserAgent { get; set; }
        public List<string> AvailableInstruments { get; set; }
        public string Implementation { get; set; }
        public string Integration { get; set; }
        public bool? InstrumentMode { get; set; }
        public bool? GuestMode { get; set; }
        public string Status { get; set; }
        public Identifiable History { get; set; }
        public Identifiable Failed { get; set; }
        public Identifiable Aborted { get; set; }
        public Identifiable Paid { get; set; }
        public Identifiable Cancelled { get; set; }
        public Identifiable FinancialTransactions { get; set; }
        public Identifiable FailedAttempts { get; set; }
        public PaymentOrderPayeeInfoDto PayeeInfo { get; set; }
        public PayerDto Payer { get; set; }
        public PaymentOrderPaymentsDto Payments { get; set; }
        public PaymentOrderCurrentPaymentDto CurrentPayment { get; set; }
        public List<ItemDto> Items { get; set; }
    }
}