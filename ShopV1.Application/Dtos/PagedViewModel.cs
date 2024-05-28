using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.Application.Dtos
{
    public class PagedViewModel<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
