using System.Collections.Generic;

namespace GameTracker.Models
{
  public class Character
  {
    public string Name;
    public static void Create(string characterName)
    {
      var character = new Character();
      character.Name = characterName;
      if(GlobalVariables.Characters == null)
        GlobalVariables.Characters = new System.Collections.Generic.List<Character>();
      GlobalVariables.Characters.Add(character);
      // lists have an Add() function to add objects to the list
    }
    public static void Destroy(string characterName)
    {
      
    }
    public static List<Character> GetAll()
    {
      if(GlobalVariables.Characters == null)
        GlobalVariables.Characters = new List<Character>();
      return GlobalVariables.Characters;  
    }
  }
}