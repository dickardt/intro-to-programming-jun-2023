

namespace Games.Tests.GolfScoring;


public class ScoringAGolfGame
{

    private readonly List<Player> _expectedWinners;
    private readonly List<Player> _expectedLosers;
    private readonly ScoreReport _report;

    public ScoringAGolfGame()
    {
        // Given 
        var game = new GolfGame();
        var p1 = new Player("Tyler", 35);
        var p2 = new Player("Dana", 95);
        game.addPlayer(p1.name, p1.score);
        game.addPlayer(p2.name, p2.score);

        _expectedWinners = new List<Player> { p1 };
        _expectedLosers = new List<Player>() { p2 };

        var scorer = new GameScorer();

        // When I ask for the score
        _report = scorer.GenerateScoreReportFor(game);

    }

    [Fact]
    public void HasCorrectWinners()
    {
        Assert.Equal(_expectedWinners, _report.Winners);

    }

    [Fact]
    public void HasCorrectLosers()
    {
        Assert.Equal(_expectedLosers, _report.Losers);
    }

    [Fact]
    public void HasCorrectAverage()
    {
        Assert.Equal(65, _report.Average);
    }

}
