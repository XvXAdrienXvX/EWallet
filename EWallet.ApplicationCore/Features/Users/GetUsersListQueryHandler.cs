using AutoMapper;
using EWallet.ApplicationCore.Interfaces.Persistance;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Features.Account
{
    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, List<UserViewModel>>
    {
        private readonly IAsyncRepository<EWallet.Domain.Users> _userRepository;
        private readonly IMapper _mapper;

        public GetUsersListQueryHandler(IMapper mapper, IAsyncRepository<EWallet.Domain.Users> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserViewModel>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var UserList = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserViewModel>>(UserList);
        }
    }
}
