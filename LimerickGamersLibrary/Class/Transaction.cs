using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    enum AccountTransaction
    {
        RentalFee,
        MembershipFee,
        LateReturnFee,
    }
    [Serializable]
   public struct Fees
    {
        public const  double RentalFee = 3;
        public const  double LateReturnFee = 1;
        public const  double MembershipFee = 20;
    };
    [Serializable]
    class Transaction
    {

        public string CustomerId { set; get; }
        public double Amount { set; get; }
        public DateTime TransactionDate { set; get; }
        public AccountTransaction TransactionType { set; get; }

        public Transaction(string customerId, double amt, DateTime date, AccountTransaction type)
        {
            CustomerId = customerId;
            TransactionDate = date;
            TransactionType = type;
            Amount = amt;
        }


    }
}
