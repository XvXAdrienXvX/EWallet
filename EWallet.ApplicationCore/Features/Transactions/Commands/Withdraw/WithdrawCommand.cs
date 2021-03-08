using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.ApplicationCore.Features.Transactions.Commands.Withdraw
{
    public class WithdrawCommand : IRequest<WithdrawCommandResponse>
    {
        public int amount { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
    }
}
