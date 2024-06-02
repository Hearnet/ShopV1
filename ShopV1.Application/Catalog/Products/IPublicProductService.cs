using ShopV1.ViewModels.Catalog.Products;
using ShopV1.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopV1.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
    }
}
 