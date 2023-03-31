using SwedbankPay.Sdk.PaymentInstruments;
using SwedbankPay.Sdk.PaymentOrders;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SwedbankPay.Sdk.Extensions
{
    public static class UriExtensions
    {
        public static Uri GetUrlWithQueryString(this Uri uri, PaymentExpand paymentExpand)
        {
            var paymentExpandQueryString = GetExpandQueryString<PaymentExpand>(paymentExpand);
            var url = !paymentExpandQueryString.IsNullOrWhiteSpace()
                ? new Uri(uri.OriginalString + paymentExpandQueryString, UriKind.RelativeOrAbsolute)
                : uri;
            return url;
        }

        public static Uri GetUrlWithQueryString(this Uri uri, PaymentOrderExpand paymentExpand)
        {
            string paymentExpandQueryString = GetExpandQueryString<PaymentOrderExpand>(paymentExpand);
            var url = !paymentExpandQueryString.IsNullOrWhiteSpace()
                ? new Uri(uri.OriginalString + paymentExpandQueryString, UriKind.RelativeOrAbsolute)
                : uri;
            return url;
        }

        private static string GetExpandQueryString<T>(Enum paymentExpand)
             where T : Enum
        {
            var intValue = Convert.ToInt64(paymentExpand);
            if (intValue == 0)
            {
                return string.Empty;
            }

            var s = new List<string>();
            foreach (var enumValue in Enum.GetValues(typeof(T)))
            {
                var name = Enum.GetName(typeof(T), enumValue);
                if (paymentExpand.HasFlag((T)enumValue) && name != "None" && name != "All")
                {
                    s.Add(name.ToLower(CultureInfo.InvariantCulture));
                }
            }

#if NET35
            var queryString = string.Join(",", s.ToArray());
#else
            var queryString = string.Join(",", s);
#endif
            return $"?$expand={queryString}";
        }
    }
}
