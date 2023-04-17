using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    public interface ITransactionCallback : IIdentifiable
    {
        public string Number { get; }
    }
}
