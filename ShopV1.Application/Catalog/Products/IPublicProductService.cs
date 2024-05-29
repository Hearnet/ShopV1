using ShopV1.Application.Catalog.Products.Dtos;
using ShopV1.Application.Catalog.Products.Dtos.Public;
using ShopV1.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopV1.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
 