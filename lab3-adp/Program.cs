using System.Text;
using lab3_adp.task1;
using lab3_adp.task2;
using lab3_adp.task3;
using lab3_adp.task4;

Console.OutputEncoding = Encoding.UTF8;

InvoiceCalculator invoiceCalculator = new InvoiceCalculator();
InvoiceRepository invoiceRepository = new InvoiceRepository();

double total = invoiceCalculator.CalculateTotal();

invoiceCalculator.CalculateTotal();
invoiceRepository.SaveToDatabase();


//////////////////////////////////////////////////////// task 2

DiscountCalculator discountCalculator = new DiscountCalculator();


CustomerBase regularCustomer = new CustomerRegular();
CustomerBase silverCustomer = new CustomerSilver();
CustomerBase goldCustomer = new CustomerGold();

discountCalculator.CalculateDiscountNEW(regularCustomer, 100);
discountCalculator.CalculateDiscountNEW(silverCustomer, 200);
discountCalculator.CalculateDiscountNEW(goldCustomer, 300);

//////////////////////////////////////////////////////// task 3

HumanWorker human = new HumanWorker();
human.Eat();
human.Sleep();
human.Work();

RobotWorker robot = new RobotWorker();
robot.Work();



//////////////////////////////////////////////////////// task 4

INotification notification = new Notification(
                "Test subject",
                "Hello, DIP!",
                "user@example.com"
            );

// Email
INotificationService emailService = new EmailService();
emailService.Send(notification);

