namespace Mediator.Structural;

public class ConcreteMediator : Mediator
{
    private List<Colleague> Colleagues = new List<Colleague>();

    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        this.Colleagues.Add(colleague);
    }

    public override void Send(string message, Colleague colleague)
    {
        this.Colleagues
            .Where(x=>x!=colleague)
            .ToList()
            .ForEach(x=>x.HandleNotifications(message));
    }
}