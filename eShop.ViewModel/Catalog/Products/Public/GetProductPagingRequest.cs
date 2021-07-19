using System;
using eShop.ViewModels.Catalog.Products.Public;

namespace eShop.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
 
    }
}
