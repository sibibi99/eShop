using System;
using System.Threading.Tasks;
using eShop.ViewModels.Catalog.Products.Manage;
using eShop.ViewModels.Common;

namespace eShop.ViewModels.Catalog.Products
{
    public interface IPublicProductService
    {
         Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);

    }
}
