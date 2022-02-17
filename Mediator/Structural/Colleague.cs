namespace Mediator.Structural;

public abstract class Colleague
{
    protected Mediator mediator;
    internal void SetMediator(Mediator mediator)
    {
        this.mediator = mediator;
    }
    
    //The virtual keyword is used to modify a method, property, indexer,
    //or event declared in the base class and allow it to be overridden in the derived class.
    public virtual void Send(string message)
    {
        // “this” pointer of a class or a stuct.
        // The this pointer represents the current instance of a class or stuct
        this.mediator.Send(message,this);
    }

    public abstract void HandleNotifications(string message);
    
}