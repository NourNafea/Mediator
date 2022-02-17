namespace Mediator.Structural;


//Define  the base class and the abstract method 
public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
    
}