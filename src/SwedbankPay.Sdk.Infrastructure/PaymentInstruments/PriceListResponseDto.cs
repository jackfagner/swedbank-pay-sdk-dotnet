using System;
using System.Collections.Generic;
using System.Linq;

namespace SwedbankPay.Sdk.PaymentInstruments
{
    internal class PriceListResponseDto
    {
        public string Id { get; set; }

        public List<PriceDto> PriceList { get; set; } = new List<PriceDto>();

        internal IPriceListResponse Map()
        {
            var priceList = new List<IPrice>();
            foreach (var item in PriceList)
            {
#if NET35
                var priceType = PriceType.Unknown;
                if (Enum.GetNames(typeof(PriceType)).Contains(item.Type))
                    priceType = (PriceType)Enum.Parse(typeof(PriceType), item.Type);
#else
                if (!Enum.TryParse(item.Type, out PriceType priceType))
                {
                    priceType = PriceType.Unknown;
                }
#endif

                priceList.Add(new Price(item.Amount, priceType, item.VatAmount));
            }
            var uri = new Uri(Id, UriKind.RelativeOrAbsolute);
            return new PriceListResponse(uri, priceList);
        }
    }
}