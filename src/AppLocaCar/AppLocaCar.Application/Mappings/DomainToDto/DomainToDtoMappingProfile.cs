using AppLocaCar.Application.Dto.User;
using AppLocaCar.Domain.Entities;
using AutoMapper;


namespace AppLocaCar.Application.Mappings.DomainToDto
{
    public class DomainToDtoMappingProfile : Profile
    {
        
        public DomainToDtoMappingProfile()
        {
            CreateMap<ApplicationUser, UserRegisterViewModel>();
        }
    }
}
