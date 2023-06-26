

namespace Games.Tests;

public class ValidatingPlayersForABowlingGame
{
    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {
        //given
        var game = new BowlingGame();

        game.addPlayer("Jim", 120);

        //then or when
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.addPlayer("Jim", 200));
    }
    [Theory]
    [InlineData(-1)]
    [InlineData(301)]
    public void InvalidScoresThrowAnException(int score)
    {
        var game = new BowlingGame();
        Assert.Throws<InvalidBowlingScoreException>(() => game.addPlayer("Jim", score));
    }
}
