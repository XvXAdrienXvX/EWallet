using System;

namespace EWallet.ApplicationCore.Features.Transactions.Commands.Withdraw
{
    public class CreateTransactionDto
    {
        public int TransactionId { get; set; }

        public int? Amount { get; set; }

        public string Sender { get; set; }

        public string Recipient { get; set; }

        public DateTime? TransactionDate { get; set; }

        public string Comment { get; set; }

        public string Status { get; set; }
    }
}