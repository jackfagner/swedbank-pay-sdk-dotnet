using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class TransactionCallbackDto
    {
        public Uri Id { get; set; }
        public string Number { get; set; }
    }
}
