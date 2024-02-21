using System;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Discount : Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            // AddNotifications(
            //     new Contract()
            //     .Requires()
            //     .IsNotNull(ExpireDate, "ExpireDate", "A data de expiração não pode ser nula.")
            // );

            Amount = amount;
            ExpireDate = expireDate;
        }

        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        public decimal Value()
        {
            if (IsValid())
                return Amount;
            else
                return 0;
        }

        public void ChangeToExpiredDate()
        {
            ExpireDate = DateTime.Now.AddDays(-10);
            Amount = 0;
        }
    }
}