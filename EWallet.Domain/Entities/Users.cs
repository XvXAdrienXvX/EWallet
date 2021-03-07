using System.Collections.Generic;

namespace EWallet.Domain
{
    public class Users : AuditableEntity
    {
        public int UserId { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public ICollection<Account> AccountList { get; set; }

        public Users()
        {
            this.AccountList = new HashSet<Account>();
        }
    }
}
