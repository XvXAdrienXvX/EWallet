using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.Domain
{
    public class Users : AuditableEntity
    {
        public int UserId { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public ICollection<Account> AccountList { get; set; }
    }
}
