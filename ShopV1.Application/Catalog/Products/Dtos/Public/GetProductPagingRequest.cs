using ShopV1.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
