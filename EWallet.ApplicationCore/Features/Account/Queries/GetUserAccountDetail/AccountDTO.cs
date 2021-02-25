using System;

namespace EWallet.ApplicationCore.Features.Account
{
    public class AccountDTO
    {
        public int AccountId { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public int? CurrentBalance { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}