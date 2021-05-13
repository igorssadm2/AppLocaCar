using AppLocaCar.Application.Dto.Response.User;
using AppLocaCar.Application.Dto.User;
using AppLocaCar.Application.Interfaces.Services;
using AppLocaCar.Domain.Entities;
using AppLocaCar.Helpers.Enums;
using AppLocaCar.Infra.Data.Context;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Application.Services
{
    public class UserService : IUserServices
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserService(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ApplicationDbContext applicationDbContext,
            IMapper mapper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = applicationDbContext;
            _mapper = mapper;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<UserLoginResponseViewModel> LoginCustomerAsync(UserLoginViewModel userLoginViewModel)
        {
            var response = new UserLoginResponseViewModel();
            try
            {

            var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.Email, userLoginViewModel.Pass, false, lockoutOnFailure: true);
            if (!result.Succeeded)
            {
                response.TypeResponse = TypeResponse.ErrorService;
                response.ChangeResponse("Não foi possivel realizar login");
                return response;
            }
            response.ChangeResponse("Login realizado com sucesso");

            return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<UserLoginResponseViewModel> LoginEmployeeAsync(UserEmployeeLoginViewModel userLoginViewModel)
        {
            var response = new UserLoginResponseViewModel();

            var ret = await _context.Users.Where(p => p.CodeEmployee == userLoginViewModel.Codigo).FirstOrDefaultAsync();

            var result = await _signInManager.PasswordSignInAsync("", userLoginViewModel.Pass, false, lockoutOnFailure: true);
            if (!result.Succeeded)
            {
                response.TypeResponse = TypeResponse.ErrorService;
                response.ChangeResponse("Não foi possivel realizar login");
                return response;
            }
            response.ChangeResponse("Login realizado com sucesso");

            return response;
        }


        //private readonly 
        public async Task<UserRegisterResponseViewModel> RegisterUserAsync(UserRegisterViewModel userRegisterViewModel)
        {

            try
            {
                var response = new UserRegisterResponseViewModel();

                if (await EmailExiste(userRegisterViewModel.Email))
                {
                    response.ChangeResponse("O e-mail já existe");
                    return response;
                }

                var userApp = _mapper.Map<ApplicationUser>(userRegisterViewModel); 

                var user = new ApplicationUser
                {
                    UserName = userRegisterViewModel.Email,
                    Email = userRegisterViewModel.Email,
                    EmailConfirmed = true,
                    typeUser = userRegisterViewModel.TypeUser
                };

                var result = await _userManager.CreateAsync(user, userRegisterViewModel.Pass);

                if (!result.Succeeded)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    result.Errors?.ToList().ForEach((n) => { stringBuilder.AppendLine($"codErro - {n.Code}  | descrErro - {n.Description}"); });
                    response.ChangeResponse(stringBuilder.ToString());
                    return response;
                }
                return response;
            }
            catch (Exception ex)
            {
                //Notificar(ex.Data. Errors.Select(x => x.Description).ToList().ToString());

                throw new Exception(ex.Message, ex);
            }
        }
        private async Task<bool> EmailExiste(string Email)
        {
            var usuarioExiste = await _userManager.FindByEmailAsync(Email);

            return usuarioExiste != null ? true : false;
        }

    }
}
