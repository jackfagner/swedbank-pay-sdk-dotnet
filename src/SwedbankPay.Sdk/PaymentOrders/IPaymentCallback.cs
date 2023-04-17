using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    public interface IPaymentCallback : IIdentifiable
    {
        public string Number { get; }
    }
}
