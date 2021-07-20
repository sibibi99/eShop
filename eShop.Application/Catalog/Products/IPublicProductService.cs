using eShop.ViewModels.Catalog.Products;
using eShop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        Task GetAllByCategoryId(GetPublicProductPagingRequest request);
    }
}