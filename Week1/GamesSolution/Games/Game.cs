﻿

namespace Games;
public abstract class Game
{
    private readonly List<Player> _players = new(); // intention revealing than Dictionary<string, int>

    protected abstract void GuardForValidScore(int score);

    public void addPlayer(string name, int score)
    {
        GuardForValidScore(score);
        GuardForPlayerAlreadyExisting(name);

        _players.Add(new Player(name, score));


    }

    internal List<Player> GetPlayers()
    {
        return _players;
    }

    private void GuardForPlayerAlreadyExisting(string name)
    {
        if (PlayerExists(name))
        {
            throw new PlayerAlreadyAddedToGameException();
        }
    }

    private bool PlayerExists(string name)
    {
        return _players.Any(p => p.name.Trim().ToLowerInvariant() == name.Trim().ToLowerInvariant());
    }
}
