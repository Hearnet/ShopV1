﻿using ShopV1.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }

        public string LanguageId { get; set; }
    }
}