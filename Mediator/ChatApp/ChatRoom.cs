namespace Mediator.ChatApp;

public abstract class ChatRoom
{
    public abstract void Register(TeamMember member);
    public abstract void Send(string from, string message);
}