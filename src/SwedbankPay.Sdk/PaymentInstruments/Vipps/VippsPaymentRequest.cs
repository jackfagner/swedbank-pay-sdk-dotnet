﻿using System.Collections.Generic;

namespace SwedbankPay.Sdk.PaymentInstruments.Vipps
{
    /// <summary>
    /// Object to create a payment for Vipps.
    /// </summary>
    public class VippsPaymentRequest
    {
        /// <summary>
        /// Instantiates a <see cref="VippsPaymentRequest"/> with the provided parameters.
        /// </summary>
        /// <param name="operation">The initial operation of this payment.</param>
        /// <param name="intent">The intent of this payment.</param>
        /// <param name="currency">The wanted currency of the payment.</param>
        /// <param name="price">Payment instrument prices.</param>
        /// <param name="description">Textual description of the payment.</param>
        /// <param name="payerReference">Merchant reference to the payer.</param>
        /// <param name="userAgent">The payers UserAgent string.</param>
        /// <param name="language">The payers prefered language.</param>
        /// <param name="urls">Object with relevant URLs for the payment.</param>
        /// <param name="payeeInfo">Object with information about the merchant.</param>
        public VippsPaymentRequest(Operation operation,
                              PaymentIntent intent,
                              Currency currency,
                              IPrice price,
                              string description,
                              string userAgent,
                              Language language,
                              IUrls urls,
                              PayeeInfo payeeInfo,
                              string payerReference)

        {
            Payment = new VippsPaymentRequestDetails(operation, intent, currency, price, description, payerReference, 
                                                userAgent, language, urls, payeeInfo);
        }

        /// <summary>
        /// Details for creating a Vipps payment.
        /// </summary>
        public VippsPaymentRequestDetails Payment { get; }
    }
}