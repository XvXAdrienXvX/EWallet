using AutoMapper;
using EWallet.ApplicationCore.Interfaces.Persistance;
using EWallet.Domain;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Features.Transactions.Commands.Withdraw
{
    public class WithdrawCommandHandler : IRequestHandler<WithdrawCommand, WithdrawCommandResponse>
    {
        private readonly ITransactionsRepository _transactionRepository;
        private readonly IMapper _mapper;

        public WithdrawCommandHandler(IMapper mapper, ITransactionsRepository transactionsRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionsRepository;
        }

        public async Task<WithdrawCommandResponse> Handle(WithdrawCommand request, CancellationToken cancellationToken)
        {
            var WithdrawCommandResponse = new WithdrawCommandResponse();

            var validator = new WithdrawCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                WithdrawCommandResponse.Success = false;
                WithdrawCommandResponse.ValidationErrors = new List<string>();

                foreach(var error in validationResult.Errors)
                {
                    WithdrawCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (WithdrawCommandResponse.Success)
            {
                var transaction = new Transaction()
                {
                    Amount = request.amount
                };

                transaction = await _transactionRepository.AddAsync(transaction);
                WithdrawCommandResponse.transaction = _mapper.Map<CreateTransactionDto>(transaction);
            }

            return WithdrawCommandResponse;
        }
    }
}
