using lab3_adp.task1;
using lab3_adp.task2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
InvoiceRepository invoiceRepository = new InvoiceRepository();

double total = invoiceCalculator.CalculateTotal();

invoiceCalculator.CalculateTotal();
invoiceRepository.SaveToDatabase();


DiscountCalculator discountCalculator = new DiscountCalculator();


CustomerBase regularCustomer = new CustomerRegular();
CustomerBase silverCustomer = new CustomerSilver();
CustomerBase goldCustomer = new CustomerGold();

discountCalculator.CalculateDiscountNEW(regularCustomer, 100);
discountCalculator.CalculateDiscountNEW(silverCustomer, 200);
discountCalculator.CalculateDiscountNEW(goldCustomer, 300);

