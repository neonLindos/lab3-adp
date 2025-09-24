
namespace lab3_adp.task2
{
    public enum CustomerType
    {
        Regular,
        Silver,
        Gold
    }

    public class DiscountCalculator
    {
        public double CalculateDiscountOLD(CustomerType customerType, double amount)
        {
            if (customerType == CustomerType.Regular)
            {
                return amount;
            }
            else if (customerType == CustomerType.Silver)
            {
                return amount * 0.9; 
            }
            else if (customerType == CustomerType.Gold)
            {
                return amount * 0.8; 
            }
            else
            {
                throw new ArgumentException("Неизвестный тип клиента");
            }
        }

        public double CalculateDiscountNEW(CustomerBase customer, double amount)
        {
            Console.WriteLine($"Расцитываем для типа покупателя {customer.Type} скидка {customer.Discount * 100}%");
            return customer.CalculateDiscount(amount);
        }
    }


}
