

namespace Games.Tests.GolfScoring;
public class ValidatingPlayersForAGolfGame
{
    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {

        // Given
        var game = new GolfGame();


        game.addPlayer("Tyler", 120);
        game.addPlayer("Dana", 200);


        // Then / When
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.addPlayer(" tyler ", 200));



    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-300)]
    public void InvalidGolfScores(int invalidScore)
    {
        var game = new GolfGame();

        Assert.Throws<InvalidGolfScoreException>(() => game.addPlayer("Joe", invalidScore));
    }
}
