using AutoMapper;
using EWallet.ApplicationCore.Interfaces.Persistance;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Features.Account.Commands.CreateAccount
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, int>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        public CreateAccountCommandHandler(IMapper mapper, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<int> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateAccountCommandValidator(_accountRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var account = _mapper.Map<EWallet.Domain.Account>(request);
            account = await _accountRepository.AddAsync(account);

            return account.AccountId;
        }
    }
}
