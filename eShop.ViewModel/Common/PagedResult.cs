using System;
using System.Collections.Generic;

namespace eShop.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
        public object ResultObj { get; set; }
    }
}
