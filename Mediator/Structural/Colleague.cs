namespace Mediator.Structural;

public abstract class Colleague
{
    protected Mediator mediator;

    internal void SetMediator(Mediator mediator)
    {
        this.mediator = mediator;
    }

    public virtual void Send(string message)
    {
        this.mediator.Send(message, this);
    }

    public abstract void HandleNotification(string message);
}