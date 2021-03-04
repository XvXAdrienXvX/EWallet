using EWallet.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Interfaces.Persistance
{
    public interface IAccountRepository : IAsyncRepository<Account>
    {
        Task<bool> IsAccountNameUnique(string name);
    }
}
