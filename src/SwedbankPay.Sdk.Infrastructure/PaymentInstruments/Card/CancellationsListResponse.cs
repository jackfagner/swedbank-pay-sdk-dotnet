﻿using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments.Card
{
    internal class CancellationsListResponse : Identifiable, ICancellationsListResponse
    {
        public CancellationsListResponse(Uri id, List<ITransaction> cancellationList) : base(id)
        {
            CancellationList = cancellationList;
        }


        public List<ITransaction> CancellationList { get; }
    }
}