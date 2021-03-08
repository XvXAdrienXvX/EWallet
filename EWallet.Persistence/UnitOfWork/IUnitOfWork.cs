using System;

namespace EWallet.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
       
        void Commit();
    }
}
