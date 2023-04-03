using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentOrder : IPaymentOrder
    {
        public PaymentOrder(PaymentOrderDto paymentOrder)
        {
            Id = new Uri(paymentOrder.Id, UriKind.RelativeOrAbsolute);
            Amount = paymentOrder.Amount;
            Created = paymentOrder.Created;
            Currency = new Currency(paymentOrder.Currency);
            CurrentPayment = paymentOrder.CurrentPayment?.Map();
            Description = paymentOrder.Description;
            Language = new Language(paymentOrder.Language);
            Metadata = paymentOrder.Metadata?.Map();
            Operation = paymentOrder.Operation;
            PayeeInfo = paymentOrder.PayeeInfo.Map();
            RemainingCancelAmount = paymentOrder.RemainingCancelAmount;
            RemainingCaptureAmount = paymentOrder.RemainingCaptureAmount;
            RemainingReversalAmount = paymentOrder.RemainingReversalAmount;
            Settings = paymentOrder.Settings;
            State = paymentOrder.State;
            Updated = paymentOrder.Updated;
            Urls = paymentOrder.Urls.Map();
            UserAgent = paymentOrder.UserAgent;
            VatAmount = paymentOrder.VatAmount;
            InitiatingSystemUserAgent = paymentOrder.InitiatingSystemUserAgent;
            
            //CheckoutV3
            AvailableInstruments = paymentOrder.AvailableInstruments ?? new List<String>();
            Implementation = paymentOrder.Implementation;
            Integration = paymentOrder.Integration;
            InstrumentMode = paymentOrder.InstrumentMode;
            GuestMode = paymentOrder.GuestMode;
            Status = paymentOrder.Status; //Same as "State"
            History = paymentOrder.History;
            Failed = paymentOrder.Failed;
            Aborted = paymentOrder.Aborted;
            Paid = paymentOrder.Paid;
            Cancelled = paymentOrder.Cancelled;
            FinancialTransactions = paymentOrder.FinancialTransactions;
            FailedAttempts = paymentOrder.FailedAttempts;

            OrderItems = paymentOrder.OrderItems?.Map();
            Payers = paymentOrder.Payer?.Map();
            if (paymentOrder.Payments != null && string.IsNullOrEmpty(paymentOrder.Payments.Id))
            {
                Payments = new Identifiable ( new Uri(paymentOrder.Payments.Id, UriKind.RelativeOrAbsolute) );
            }
        }

        public Uri Id { get; }
        public Amount Amount { get; }
        public DateTime Created { get; }
        public Currency Currency { get; }
        public ICurrentPaymentResponse CurrentPayment { get; }
        public string Description { get; }
        public Language Language { get; }
        public Metadata Metadata { get; }
        public string Operation { get; }
        public OrderItemListResponse OrderItems { get; }
        public IPayeeInfo PayeeInfo { get; }
        public PayerResponse Payers { get; }
        public Identifiable Payments { get; }
        public Amount RemainingCancelAmount { get; }
        public Amount RemainingCaptureAmount { get; }
        public Amount RemainingReversalAmount { get; }
        public Identifiable Settings { get; }
        public State State { get; }
        public DateTime Updated { get; }
        public IUrls Urls { get; }
        public string UserAgent { get; }
        public Amount VatAmount { get; }
        public string InitiatingSystemUserAgent { get; }
        public IList<string> AvailableInstruments { get; }
        public string Implementation { get; }
        public string Integration { get; }
        public bool? InstrumentMode { get; }
        public bool? GuestMode { get; }
        public State Status { get; }
        public Identifiable History { get; }
        public Identifiable Failed { get; }
        public Identifiable Aborted { get; }
        public Identifiable Paid { get; }
        public Identifiable Cancelled { get; }
        public Identifiable FinancialTransactions { get; }
        public Identifiable FailedAttempts { get; }
    }
}