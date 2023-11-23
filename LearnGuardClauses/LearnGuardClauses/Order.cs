using Ardalis.GuardClauses;
using System.Text;

namespace LearnGuardClauses
{
    // This is of Steve Smith (@ardalis) GitHub guardclauses repo, with some minor changes
    public class Order
    {
        private readonly string name;
        private readonly int quantity;
        private readonly long max;
        private readonly decimal unitPrice;
        private readonly DateTime dateCreated;

        public Order(string Name, int Quantity, long Max, decimal UnitPrice, DateTime DateCreated)
        {
            name = Guard.Against.NullOrWhiteSpace(Name);
            quantity = Guard.Against.NegativeOrZero(Quantity);
            max = Guard.Against.Zero(Max);
            unitPrice = Guard.Against.Negative(UnitPrice);
            dateCreated = Guard.Against.OutOfSQLDateRange(DateCreated, DateCreated.ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Quantity: {quantity}");
            sb.AppendLine($"Max: {max}");
            sb.AppendLine($"UnitPrice: {unitPrice:C}");
            sb.AppendLine($"DateCreated: {dateCreated}");

            return sb.ToString();
        }
    }
}
