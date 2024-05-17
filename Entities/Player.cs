using System.Text;
using QuestionService;

namespace FiftyQuestionsClient.Entities;

internal class Player
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public PlayerRole _Role { get; set; }

    public Player(string name, PlayerRole role)
    {
        Id = Guid.NewGuid();
        Name = name;
        _Role = role;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Name: " + Name);
        sb.Append("  Id: " + Id.ToString());
        return sb.ToString();
    }
}
