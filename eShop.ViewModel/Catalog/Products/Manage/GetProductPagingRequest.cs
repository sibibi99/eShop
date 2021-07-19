using System;
using System.Collections.Generic;
using eShop.ViewModels.Catalog.Products;

namespace eShop.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds  { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
