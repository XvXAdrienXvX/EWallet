using System;

namespace EWallet.Domain
{
    public class Account : AuditableEntity
    {
        public int AccountId { get; set; }

        public int UserId { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public int? CurrentBalance { get; set; }

        public DateTime? DateCreated { get; set; }

        public Users user { get; set; }
    }
}
