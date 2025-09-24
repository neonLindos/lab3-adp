Произведите корректную (правильную) по вашему мнению реализацию с применением принципа Dependency-Inversion Principle, DIP:
Рассмотрим пример, где класс Notification зависит от конкретной реализации класса EmailService:
```
public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Отправка Email: {message}");
    }
}

public class Notification
{
    private EmailService _emailService;

    public Notification()
    {
        _emailService = new EmailService();
    }

    public void Send(string message)
    {
        _emailService.SendEmail(message);
    }
}
```

В этом примере класс Notification жестко связан с конкретной реализацией EmailService. Если в будущем нужно будет изменить способ отправки уведомлений (например, добавить SMS или push-уведомления), придется изменять класс Notification, что нарушает DIP.
Чтобы соблюдать DIP, вам необходимо использовать абстракцию в виде интерфейса для отделения высокоуровневого модуля от низкоуровневого.
