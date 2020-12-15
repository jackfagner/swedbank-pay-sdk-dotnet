﻿using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments.Card
{
    internal class TransactionListResponse : Identifiable, ITransactionListResponse
    {
        public TransactionListResponse(Uri id, List<ITransaction> transactionList)
            : base(id)
        {
            TransactionList = transactionList;
        }


        public List<ITransaction> TransactionList { get; }
    }
}