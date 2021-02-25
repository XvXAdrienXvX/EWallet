using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.ApplicationCore.Features.Account
{
    public class UserAccountViewModel
    {
        public int UserId { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public ICollection<AccountDTO> AccountList { get; set; }
    }
}
