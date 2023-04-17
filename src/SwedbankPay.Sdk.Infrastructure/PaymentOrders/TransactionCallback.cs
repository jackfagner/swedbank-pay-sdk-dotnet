using System;
using System.Collections.Generic;
using System.Text;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class TransactionCallback : ITransactionCallback
    {
        public TransactionCallback(TransactionCallbackDto transactionCallback)
        {
            this.Id = transactionCallback.Id;
            this.Number = transactionCallback.Number;
        }

        public Uri Id { get; }

        public string Number { get; }
    }
}
