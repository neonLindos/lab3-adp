using lab3_adp.task1.models;

namespace lab3_adp.task1
{
    public class InvoiceCalculator
    {
        private List<Item> Items;
        private const double TaxRate = 0.15;

        public InvoiceCalculator()
        {
            Items = new List<Item>();
        }

        public double CalculateTotal()
        {
            double subTotal = 10;
            foreach (var item in Items)
            {
                subTotal += item.Price;
            }
            double total = subTotal + subTotal * TaxRate;
            System. Console.WriteLine($"Subtotal: {subTotal}, Tax: {subTotal * TaxRate}, Total: {total}");
            return total;
        }
    }
}
