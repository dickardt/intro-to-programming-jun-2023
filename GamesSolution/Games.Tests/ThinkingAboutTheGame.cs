

namespace Games.Tests;

public class ThinkingAboutTheGame
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
}
