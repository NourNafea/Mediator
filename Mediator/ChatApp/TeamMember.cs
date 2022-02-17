namespace Mediator.ChatApp;

public abstract class TeamMember
{
    public string Name { get; }
    private ChatRoom ChatRoom;

    public TeamMember(string name)
    {
        this.Name = name;
    }
    
    internal void SetChatRoom(ChatRoom chatRoom)
    {
        this.ChatRoom = chatRoom;
    }

    public void Send(string message)
    {
        this.ChatRoom.Send(this.Name , message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"from {from}: '{message}'");
    }

}