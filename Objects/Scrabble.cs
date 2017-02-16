using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleGame
{
  public class Scrabble
  {
    private string _inputWords;
    public List<char> _inputList = new List<char>{};
    public int _testNo;

    public Scrabble(string inputWords)
    {
      _inputWords = inputWords;
    }

    public List<string> SplitWords()
    {
      char[] inputArray = _inputWords.ToCharArray();

      foreach (char letter in inputArray)
      {
        _inputList.Add(letter);
      };

      var result = _inputList.Select(c => c.ToString()).ToList();
      return result;
    }

    public bool ContainsA(List<string> result)
    {
      foreach(string letter in result)
      {
        if(letter == "a")
        {
        _testNo =1;
        }
      }
      if(_testNo == 1);
      { return true ;}
    }
  }
}
