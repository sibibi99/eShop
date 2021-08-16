using System;
using System.Threading.Tasks;
using eShop.ViewModels.Common;
using eShop.ViewModels.System.Users;

namespace eShop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest registerRequest);
    }
}
