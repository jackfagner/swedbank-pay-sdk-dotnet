using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    public interface IPaymentOrderCallback : IIdentifiable
    {
        public string Instrument { get; }
    }
}
