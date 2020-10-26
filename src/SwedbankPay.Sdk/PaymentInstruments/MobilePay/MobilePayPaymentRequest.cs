﻿using SwedbankPay.Sdk.Common;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SwedbankPay.Sdk.PaymentInstruments.MobilePay
{
    public class MobilePayPaymentRequest
    {
        public MobilePayPaymentRequest(Operation operation,
                              PaymentIntent intent,
                              CurrencyCode currency,
                              List<IPrice> prices,
                              string description,
                              string userAgent,
                              CultureInfo language,
                              IUrls urls,
                              PayeeInfo payeeInfo,
                              Uri shopslogoUrl,
                              string payerReference = null,
                              Dictionary<string, object> metadata = null,
                              PrefillInfo prefillInfo = null)

        {
            Payment = new MobilePayPaymentRequestPaymentObject(operation, intent, currency, prices, description, payerReference, userAgent, language, urls, payeeInfo, metadata, prefillInfo);
            MobilePay = new MobilePayPaymentRequestObject(shopslogoUrl);
        }


        public MobilePayPaymentRequestPaymentObject Payment { get; }
        public MobilePayPaymentRequestObject MobilePay { get; }
    }
}
