using Mediator.ChatApp;
using Mediator.Structural;

class Program
{
    static void Main(string[] args)
    {
        var teamChat = new TeamChatRoom();
        var Nour = new Developer("Nour");       
        var Hassan = new Developer("Hassan");
        var Taha = new Developer("Taha");
        var Reem = new Tester("Reem");
        var Eman = new Tester("Eman");
        teamChat.RegisterMembers(Nour,Hassan,Taha,Reem,Eman);
        Nour.Send("Hello everybody, we're going to be deploying at 2pm today.");
        Taha.Send("Ok. thanks for letting us know.");
        Console.WriteLine("============================================================================");
        Nour.SendTo<Developer>("Make sure to execute your unit tests before checking in.");

    }
    // static void Main(string[] args) //Structural
    // {
    //     var mediator = new ConcreteMediator();
    //
    //     var c1 = mediator.CreateColleague<Colleague1>();
    //     var c2 = mediator.CreateColleague<Colleague2>();
    //     
    //     c1.Send("Hello, World! (From c1)");
    //     c2.Send("Hi, there! (From c2)");
    // }
}