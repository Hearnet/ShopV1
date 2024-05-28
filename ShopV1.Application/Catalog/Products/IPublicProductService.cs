using ShopV1.Application.Catalog.Products.Dtos;
using ShopV1.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopV1.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
 