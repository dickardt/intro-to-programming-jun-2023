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
        //Gaurd Clauses
        GaurdForValidScore(score);
        GaurdForValidPlayerName(name);
        _player.Add(new Player(name, score));
    }

    private void GaurdForValidPlayerName(string name)
    {
        if (PlayerExsists(name)) { throw new PlayerAlreadyAddedToGameException(); }
    }

    private static void GaurdForValidScore(int score)
    {
        if (InvalidScoreCheck(score)) { throw new InvalidBowlingScoreException(); }
    }

    private static bool InvalidScoreCheck(int score)
    {
        return score < 0 || score > 300;
    }

    private bool PlayerExsists(string name)
    {
        return _player.Any(p => p.name.ToLowerInvariant().Trim() == name.ToLowerInvariant().Trim());
    }

    internal List<Player> GetPlayers()
    {
        return _player;
    }
}

public record Player(string name, int score);