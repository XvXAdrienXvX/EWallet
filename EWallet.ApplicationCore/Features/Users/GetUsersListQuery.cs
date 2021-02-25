using MediatR;
using System.Collections.Generic;

namespace EWallet.ApplicationCore.Features.Account
{
    public class GetUsersListQuery : IRequest<List<UserViewModel>>
    {
    }
}
