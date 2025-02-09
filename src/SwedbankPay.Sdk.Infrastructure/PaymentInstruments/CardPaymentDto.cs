﻿using System;

using SwedbankPay.Sdk.PaymentInstruments.Card;

namespace SwedbankPay.Sdk.PaymentInstruments
{
    internal class CardPaymentDto
    {
        public long Amount { get; set; }

        public long VatAmount { get; set; }

        public long RemainingCaptureAmount { get; set; }

        public long RemainingCancellationAmount { get; set; }

        public long RemainingReversalAmount { get; set; }

        public AuthorizationListDto Authorizations { get; set; }

        public CancellationTransactionDto Cancellations { get; set; }

        public CaptureListDto Captures { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Instrument { get; set; }

        public string Intent { get; set; }

        public string Language { get; set; }

        public long Number { get; set; }

        public string Operation { get; set; }

        public PayeeInfoResponseDto PayeeInfo { get; set; }

        public string PayerReference { get; set; }

        public string InitiatingSystemUserAgent { get; set; }

        public PricesDto Prices { get; set; }

        public ReversalListResponseDto Reversals { get; set; }

        public string State { get; set; }

        public TransactionListResponseDto Transactions { get; set; }

        public VerificationListResponseDto Verifications { get; set; }

        public UrlsDto Urls { get; set; }

        public string UserAgent { get; set; }

        public string RecurrenceToken { get; set; }

        public MetadataDto Metadata { get; set; }
    }
}