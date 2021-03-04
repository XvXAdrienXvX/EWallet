using EWallet.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EWallet.ApplicationCore.Interfaces.Persistance
{
    public interface ITransactionsRepository : IAsyncRepository<Transaction>
    {
    }
}
