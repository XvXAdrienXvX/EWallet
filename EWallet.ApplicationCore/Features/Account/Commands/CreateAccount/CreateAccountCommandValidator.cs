using EWallet.ApplicationCore.Interfaces.Persistance;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Features.Account.Commands.CreateAccount
{
    public class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
    {
        private readonly IAccountRepository _accountRepository;
        public CreateAccountCommandValidator(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;

            RuleFor(prop => prop.AccountName)
                   .NotEmpty()
                   .WithMessage("{PropertyName} is required")
                   .NotNull()
                   .MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters");

            RuleFor(prop => prop)
                   .MustAsync(AccountNameUnique)
                   .WithMessage("An account with the same name already exists");
                
        }

        private async Task<bool> AccountNameUnique(CreateAccountCommand command, CancellationToken token)
        {
            return !(await _accountRepository.IsAccountNameUnique(command.AccountName));
        }
    }
}
