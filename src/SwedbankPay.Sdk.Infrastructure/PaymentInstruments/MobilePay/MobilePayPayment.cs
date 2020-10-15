﻿using SwedbankPay.Sdk.PaymentInstruments;
using System;
using System.Globalization;

namespace SwedbankPay.Sdk.PaymentInstruments.MobilePay
{
    public class MobilePayPayment : IMobilePayPayment
    {
        public MobilePayPayment(MobilePayPaymentDto payment)
        {
            Amount = payment.Amount;
            Authorizations = payment.Authorizations.Map();
            Cancellations = payment.Cancellations.Map();
            Captures = payment.Captures.Map();
            Created = payment.Created;
            Updated = payment.Updated;
            Currency = payment.Currency;
            Description = payment.Description;
            Id = payment.Id;
            Instrument = Enum.Parse<PaymentInstrument>(payment.Instrument);
            Intent = Enum.Parse<PaymentIntent>(payment.Intent);
            Language = payment.Language;
            Number = payment.Number;
            Operation = new Operation(payment.Operation, payment.Operation);
            PayeeInfo = payment.PayeeInfo.Map();
            PayerReference = payment.PayerReference;
            InitiatingSystemUserAgent = payment.InitiatingSystemUserAgent;
            Prices = payment.Prices.Map();
            Reversals = payment.Reversals.Map();
            State = payment.State;
            Transactions = payment.Transactions.Map();
            Urls = payment.Urls.Map();
            UserAgent = payment.UserAgent;
            Metadata = payment.Metadata;
        }

        public Amount Amount { get; }
        public IMobilePayPaymentAuthorizationListResponse Authorizations { get; }
        public ICancellationsListResponse Cancellations { get; }
        public ICapturesListResponse Captures { get; }
        public DateTime Created { get; }
        public DateTime Updated { get; }
        public CurrencyCode Currency { get; }
        public string Description { get; }
        public Uri Id { get; }
        public PaymentInstrument Instrument { get; }
        public PaymentIntent Intent { get; }
        public CultureInfo Language { get; }
        public string Number { get; }
        public Operation Operation { get; }
        public PayeeInfo PayeeInfo { get; }
        public string PayerReference { get; }
        public string InitiatingSystemUserAgent { get; }
        public IPricesListResponse Prices { get; }
        public IReversalsListResponse Reversals { get; }
        public State State { get; }
        public ITransactionListResponse Transactions { get; }
        public IUrls Urls { get; }
        public string UserAgent { get; }
        public MetadataResponse Metadata { get; }
    }
}