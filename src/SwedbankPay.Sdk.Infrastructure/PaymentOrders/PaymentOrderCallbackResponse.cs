using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace SwedbankPay.Sdk.PaymentOrders
{
    internal class PaymentOrderCallbackResponse : IPaymentOrderCallbackResponse
    {
        public PaymentOrderCallbackResponse(String jsonContent)
        {
            var response = JsonSerializer.Deserialize<PaymentOrderCallbackResponseDto>(jsonContent, JsonSerialization.JsonSerialization.Settings);

            this.OrderReference = response.OrderReference;
            this.PaymentOrder = new PaymentOrderCallback(response.PaymentOrder);
            this.Payment = new PaymentCallback(response.Payment);
            this.Transaction = new TransactionCallback(response.Transaction);
        }

        public string OrderReference { get; }

        public IPaymentOrderCallback PaymentOrder { get; }

        public IPaymentCallback Payment { get; }

        public ITransactionCallback Transaction { get; }
    }
}
