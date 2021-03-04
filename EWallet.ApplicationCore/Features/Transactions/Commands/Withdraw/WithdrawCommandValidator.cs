using FluentValidation;

namespace EWallet.ApplicationCore.Features.Transactions.Commands.Withdraw
{
    public class WithdrawCommandValidator : AbstractValidator<WithdrawCommand>
    {
        public WithdrawCommandValidator()
        {
        }
    }
}