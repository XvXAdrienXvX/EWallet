using MediatR;
using System;
using System.Collections.Generic;

namespace EWallet.ApplicationCore.Features.Account
{
    public class GetUserAccountDetailQuery : IRequest<UserAccountViewModel>
    {
        public int Id { get; set; }
    }
}
