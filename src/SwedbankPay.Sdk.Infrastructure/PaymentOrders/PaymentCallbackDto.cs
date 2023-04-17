using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentCallbackDto
    {
        public Uri Id { get; set; }
        public string Number { get; set; }
    }
}
