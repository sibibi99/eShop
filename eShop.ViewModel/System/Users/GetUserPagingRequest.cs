using System;
using eShop.ViewModels.Common;

namespace eShop.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
 