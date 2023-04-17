using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentOrderCallbackResponseDto
    {
        public string OrderReference { get; set; }

        public PaymentOrderCallbackDto PaymentOrder { get; set; }

        public PaymentCallbackDto Payment { get; set; }

        public TransactionCallbackDto Transaction { get; set; }
    }
}
