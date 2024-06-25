using ShopV1.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
