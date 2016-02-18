using Nancy;
using ScrabbleScore.Objects;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        int model = 0;
        return View["index.cshtml", model];
      };
      Post["/"] = _ =>
      {
        return View["index.cshtml", ScrabbleScores.ScoreWord(Request.Form["input"])];
      };
    }
  }
}
