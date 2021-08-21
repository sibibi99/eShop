using System;
using System.Threading.Tasks;
using eShop.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace eShop.AdminApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        // Phương thức Invoke trả về 1 view Component Result
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
