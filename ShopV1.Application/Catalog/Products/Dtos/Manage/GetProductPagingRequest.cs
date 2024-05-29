using ShopV1.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
