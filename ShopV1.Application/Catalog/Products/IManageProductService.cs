﻿using ShopV1.Application.Catalog.Products.Dtos;
using ShopV1.Application.Catalog.Products.Dtos.Manage;
using ShopV1.Application.Dtos;
using System.Threading.Tasks;

namespace ShopV1.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);


        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
