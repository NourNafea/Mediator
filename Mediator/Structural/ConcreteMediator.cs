namespace Mediator.Structural;

public class ConcreteMediator : Mediator
{
    private List<Colleague> Colleagues = new List<Colleague>();
    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        this.Colleagues.Add(colleague);
    }
    public T CreateColleague<T>() where T : Colleague, new()
    {
        var c = new T();
        c.SetMediator(this);
        this.Colleagues.Add(c);
        return c;
    }
    public override void Send(string message, Colleague colleague)
    {
        this.Colleagues.Where(x=>x!=colleague).ToList().ForEach(x=>x.HandleNotification(message));
    }
}