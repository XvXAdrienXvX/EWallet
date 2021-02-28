using EWallet.Domain;
using MediatR;
using System;

namespace EWallet.ApplicationCore.Features.Account.Commands.CreateAccount
{
    public class CreateAccountCommand : IRequest<int>
    {
        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public int? CurrentBalance { get; set; }

        public DateTime? DateCreated { get; set; }

        public Users user { get; set; }
    }
}
