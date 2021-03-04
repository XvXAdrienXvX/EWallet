using EWallet.ApplicationCore.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.ApplicationCore.Features.Transactions.Commands.Withdraw
{
    public class WithdrawCommandResponse : BaseResponse
    {
        public WithdrawCommandResponse() : base()
        {

        }

        public CreateTransactionDto transaction {get;set;}
    }
}
