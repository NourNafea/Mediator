namespace Mediator.Structural;

public class Colleague2 :Colleague
{
    public Colleague2(Mediator mediator) : base(mediator)
    {
    }

    public override void HandleNotifications(string message)
    {
        Console.WriteLine($"Colleague2 receives notification message: {message}");
    }
}