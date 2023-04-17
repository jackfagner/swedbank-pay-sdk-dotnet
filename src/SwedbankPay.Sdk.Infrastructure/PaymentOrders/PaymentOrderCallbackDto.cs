using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentOrderCallbackDto
    {
        public Uri Id { get; set; }
        public string Instrument { get; set; }
    }
}
