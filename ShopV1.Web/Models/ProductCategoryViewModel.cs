using ShopV1.ViewModels.Catalog.Categories;
using ShopV1.ViewModels.Catalog.Products;
using ShopV1.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Web.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}
