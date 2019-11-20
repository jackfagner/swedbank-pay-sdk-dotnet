﻿namespace SwedbankPay.Sdk.Consumers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using SwedbankPay.Sdk.PaymentOrders;

    public class ConsumersRequest
    {
        public ConsumersRequest()
        {
            Operation = Operation.Initiate;
        }

        [JsonConverter(typeof(TypedSafeEnumValueConverter<Operation, string>))]
        public Operation Operation { get; }

        /// <summary>
        /// The MSISDN (mobile phone number) of the payer. Format Sweden: +46707777777. Format Norway: +4799999999.
        /// </summary>
        public string Msisdn { get; set; }

        /// <summary>
        /// The e-mail address of the payer.
        /// </summary>
        public EmailAddress Email { get; set; }

        /// <summary>
        /// Consumers country of residence. Used by the consumerUi for validation on all input fields.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CountryCode ConsumerCountryCode { get; set; }

        public NationalIdentifier NationalIdentifier { get; set; }
    }
}
