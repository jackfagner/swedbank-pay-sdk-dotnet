﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace SwedbankPay.Sdk.PaymentInstruments.Invoice
{
    public class InvoicePaymentDto
    {
        public int Amount { get; set; }
        public int RemainingCaptureAmount { get; set; }
        public int RemainingCancellationAmount { get; set; }
        public int RemainingReversalAmount { get; set; }
        public InvoicePaymentAuthorizationListDto Authorizations { get; set; }
        public ICancellationsListResponse Cancellations { get; set; }
        public ICapturesListResponse Captures { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public Uri Id { get; set; }
        public string Instrument { get; set; }
        public string Intent { get; set; }
        public CultureInfo Language { get; set; }
        public string Number { get; set; }
        public string Operation { get; set; }
        public PayeeInfoDto PayeeInfo { get; set; }
        public string PayerReference { get; set; }
        public string InitiatingSystemUserAgent { get; set; }
        public PricesDto Prices { get; set; }
        public ReversalsListResponseDto Reversals { get; set; }
        public string State { get; set; }
        public ITransactionListResponse Transactions { get; set; }
        public UrlsDto Urls { get; set; }
        public string UserAgent { get; set; }
        public Dictionary<string, object> Metadata { get; set; }
    }
}