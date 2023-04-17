using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentCallback : IPaymentCallback
    {
        public PaymentCallback(PaymentCallbackDto paymentCallback)
        {
            this.Id = paymentCallback.Id;
            this.Number = paymentCallback.Number;
        }

        public Uri Id { get; }

        public string Number { get; }
    }
}
