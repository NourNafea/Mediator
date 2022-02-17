namespace Mediator.ChatApp;

public class TeamChatRoom : ChatRoom
{
    private List<TeamMember> TeamMembers = new List<TeamMember>();
    public override void Register(TeamMember member)
    {
        member.SetChatRoom(this);
        this.TeamMembers.Add(member);
    }

    public override void Send(string from, string message)
    {
        this.TeamMembers.ForEach(x=>x.Receive(from,message));
    }

    public void RegisterMembers(params TeamMember[] teamMembers)
    {
        foreach (var member in teamMembers)
        {
            this.Register(member);
        }
    }
}