using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.Domain
{
    public class Transaction : AuditableEntity
    {
        public int TransactionId { get; set; }

        public int AccountId { get; set; }

        public int TransactionType { get; set; }

        public int? Amount { get; set; }

        public string Sender { get; set; }

        public string Recipient { get; set; }

        public DateTime? TransactionDate { get; set; }

        public string Comment { get; set; }

        public string Status { get; set; }

        public ICollection<Account> AccountList { get; set; }

        public Transaction()
        {
            this.AccountList = new HashSet<Account>();
        }
    }
}
