using System.Collections.Generic;
using Xunit;
namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void isWord_forWordBeingALettter_1()
    {
      string testWord = "a";
      Assert.Equal(1, ScrabbleScore.ScoreWord(testWord));
    }
  }
}
