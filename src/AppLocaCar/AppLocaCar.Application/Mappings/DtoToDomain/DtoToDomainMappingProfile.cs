using AppLocaCar.Application.Dto.User;
using AppLocaCar.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Application.Mappings.DtoToDomain
{
    public class DtoToDomainMappingProfile: Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<UserRegisterViewModel, ApplicationUser>();
        }
    }
}
