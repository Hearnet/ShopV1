using ShopV1.ViewModels.Catalog.Products;
using ShopV1.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.Web.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}
