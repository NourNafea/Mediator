using Mediator.Structural;

class Program
{
    static void Main(string[] args)
    {
        var mediator = new ConcreteMediator();

        var c1 = mediator.CreateColleague<Colleague1>();
        var c2 = mediator.CreateColleague<Colleague2>();
        
        c1.Send("Hello, World! (From c1)");
        c2.Send("Hi, there! (From c2)");
    }
}