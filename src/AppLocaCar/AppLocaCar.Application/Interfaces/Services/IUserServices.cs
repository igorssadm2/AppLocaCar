
using AppLocaCar.Application.Dto.Response.User;
using AppLocaCar.Application.Dto.User;
using System.Threading.Tasks;

namespace AppLocaCar.Application.Interfaces.Services
{
     public interface  IUserServices
    {
        Task<UserRegisterResponseViewModel> RegisterUserAsync(UserRegisterViewModel userRegisterViewModel);
        Task<UserLoginResponseViewModel> LoginCustomerAsync(UserLoginViewModel userLoginViewModel);
        Task<UserLoginResponseViewModel> LoginEmployeeAsync(UserEmployeeLoginViewModel userLoginViewModel);
        Task Logout();
    }
}
