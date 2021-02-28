using AutoMapper;
using EWallet.ApplicationCore.Interfaces.Persistance;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Features.Account
{
    public class GetUserAccountDetailHandler : IRequestHandler<GetUserAccountDetailQuery, UserAccountViewModel>
    {
        private readonly IAsyncRepository<EWallet.Domain.Users> _userRepository;
        private readonly IAsyncRepository<EWallet.Domain.Account> _accountRepository;
        private readonly IMapper _mapper;

        public GetUserAccountDetailHandler(IMapper mapper, IAsyncRepository<EWallet.Domain.Users> userRepository,
            IAsyncRepository<EWallet.Domain.Account> accountRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
        }

        public async Task<UserAccountViewModel> Handle(GetUserAccountDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);
            var userAccountDTO = _mapper.Map<UserAccountViewModel>(user);

            var userAccounts = await _accountRepository.GetAllByIdAsync(userAccountDTO.UserId);

            userAccountDTO.AccountList = _mapper.Map<List<AccountDTO>>(userAccounts);

            return userAccountDTO;
        }
    }
}
