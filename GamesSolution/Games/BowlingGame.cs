namespace Games;

public class BowlingGame
{
    private readonly List<Player> _player;
    public BowlingGame()
    {
        _player = new();
    }

    public void addPlayer(string name, int score)
    {
        if (PlayerExsists(name))
        {
            throw new PlayerAlreadyAddedToGameException();
        }
        else
        {
            _player.Add(new Player(name, score));
        }
    }

    private bool PlayerExsists(string name)
    {
        return _player.Any(p => p.name == name || p.name.ToLower() == name.ToLower() || p.name.ToUpper() == name.ToUpper() || p.name.Trim() == name.Trim());
    }
}

public record Player(string name, int score);