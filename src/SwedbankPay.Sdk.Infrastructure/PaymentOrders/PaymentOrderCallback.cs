using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentOrderCallback : IPaymentOrderCallback
    {
        public PaymentOrderCallback(PaymentOrderCallbackDto paymentOrderCallback)
        {
            this.Id = paymentOrderCallback.Id;
            this.Instrument = paymentOrderCallback.Instrument;
        }

        public Uri Id { get; }
        public string Instrument { get; }

        
    }
}
