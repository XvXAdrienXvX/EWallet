using AutoMapper;
using EWallet.ApplicationCore.Features.Account;
using EWallet.Domain;

namespace EWallet.ApplicationCore.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Users, UserViewModel>().ReverseMap(); 
            CreateMap<Users, UserAccountViewModel>().ReverseMap();
            CreateMap<Account, AccountDTO>();

        }
    }
}
