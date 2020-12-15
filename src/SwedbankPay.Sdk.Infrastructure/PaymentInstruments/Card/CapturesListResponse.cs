﻿using System;
using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments.Card
{
    internal class CapturesListResponse : Identifiable, ICapturesListResponse
    {
        public CapturesListResponse(Uri id, List<ITransaction> captureList) : base(id)
        {
            CaptureList = captureList;
        }


        public List<ITransaction> CaptureList { get; }
    }
}