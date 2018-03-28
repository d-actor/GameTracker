using System.Collections.Generic;

namespace GameTracker
{
  public static class GlobalVariables
  {
    public static List<GameTracker.Models.Character> Characters {get; set;}
      = new List<GameTracker.Models.Character>();
  }
}