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
        return View["index.cshtml"];
      };
      Post["/output"] = _ =>
      {

        return View["output.cshtml"];
      };
    }
  }
}
