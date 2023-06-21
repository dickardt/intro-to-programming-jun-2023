namespace Games;

public class GameScorer
{


    public ScoreReport GenerateScoreReportFor(BowlingGame game)
    {
        ScoreReport scoreReport = new ScoreReport();
        var winningPlayers = new List<Player>();
        var losingPlayers = new List<Player>();
        var players = game.GetPlayers();
        var max = players.Max(p =>p.score);
        var min = players.Min(p =>p.score);
        var avg = players.Average(p => p.score);

  
        
        winningPlayers = players.Where(p => p.score == max).ToList();
        losingPlayers = players.Where(p => p.score == min && min != max).ToList();
        return new ScoreReport {
            Winners = winningPlayers,
            Losers = max == min ? null : players.Where(p => p.score == min).ToList(),
            Average = avg
        };
    }
}