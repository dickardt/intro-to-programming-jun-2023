namespace Games;

public record ScoreReport
{
    public List<Player> Winners { get; init; } = new();
    public List<Player> Losers { get; init; } = new();
    public double Average = 0;
}