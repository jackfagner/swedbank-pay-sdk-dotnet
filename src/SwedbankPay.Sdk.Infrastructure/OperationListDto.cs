﻿using System.Collections.Generic;
using System.Linq;

namespace SwedbankPay.Sdk
{
    internal class OperationListDto : List<HttpOperationDto>
    {
        public OperationListDto()
        {
        }

        public OperationListDto(IEnumerable<HttpOperationDto> operations)
            : base(operations)
        {
        }

        public override string ToString()
        {
#if NET35
            return string.Join(", ", this.Select(o => o.Rel).ToArray());
#else
            return string.Join(", ", this.Select(o => o.Rel));
#endif
        }

        public IOperationList Map()
        {
            var list = new OperationList();
            foreach (var item in this)
            {
                var rel = new LinkRelation(item.Rel);
                list.Add(new HttpOperation(item.Href, rel, item.Method, item.ContentType));
            }
            return list;
        }
    }
}