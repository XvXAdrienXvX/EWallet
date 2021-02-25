using EWallet.Domain;

namespace EWallet.ApplicationCore.Interfaces.Persistance
{
    public interface IUserRepository : IAsyncRepository<Users>
    {
    }
}
