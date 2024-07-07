using ShopV1.ViewModels.Catalog.Products;
using ShopV1.ViewModels.Common;
using ShopV1.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopV1.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}
