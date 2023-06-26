

using Xunit;

namespace Games.Tests;

public class ScoringABowlingGame
{
    private readonly List<Player> _expectedWinners;
    private readonly List<Player> _expectedLosers;
    private readonly double _expectedAverage;
    private readonly ScoreReport _scoreReport;
    public ScoringABowlingGame()
    {
        //given I have a game with > player
        var game = new BowlingGame();

        var p1 = new Player("Tyler", 11);
        var p2 = new Player("Dana", 135);
        var p3 = new Player("Szpak", 156);
        game.addPlayer(p1.name,p1.score);
        game.addPlayer(p2.name, p2.score);
        game.addPlayer(p3.name, p3.score);

        _expectedWinners = new List<Player> { p3 };
        _expectedLosers = new List<Player>() { p1 };
        _expectedAverage = (double)(p1.score + p2.score +p3.score)/3 ;

        var scorer = new GameScorer();
        //when I ask for the score
        _scoreReport = scorer.GenerateScoreReportFor(game);

        //Then I should see winners and losers and the average
        
        
        

    }

    [Fact]
    public void CorrectWinners()
    {
        Assert.Equal(_expectedWinners, _scoreReport.Winners);
    }
    [Fact]
    public void CorrectLosers()
    {
        Assert.Equal(_expectedLosers, _scoreReport.Losers);
    }
    [Fact]
    public void CorrectAverage()
    {
        Assert.Equal(_expectedAverage, _scoreReport.Average);
    }
}
