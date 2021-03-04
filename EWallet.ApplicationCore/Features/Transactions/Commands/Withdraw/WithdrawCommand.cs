using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.ApplicationCore.Features.Transactions.Commands.Withdraw
{
    public class WithdrawCommand : IRequest<WithdrawCommandResponse>
    {
        public int amount { get; set; }
    }
}
