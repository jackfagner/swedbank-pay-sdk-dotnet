using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    public interface IPaymentOrderCallbackResponse
    {
        public string OrderReference { get; }

        public IPaymentOrderCallback PaymentOrder { get; }

        public IPaymentCallback Payment { get; }

        public ITransactionCallback Transaction { get; }
    }
}
