using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleGame
{
  public class Scrabble
  {
    private string _inputWords;
    public string[] scoreOne = new string[]{"a","i","e","o","u","l","n","r","s","t"};
    public string[] scoreTwo = new string[]{"d", "g"};
    public string[] scoreThree = new string[]{"b", "c", "m", "p"};
    public string[] scoreFour = new string[]{"f", "h", "v", "w", "y"};
    public string[] scoreFive = new string[]{"k"};
    public string[] scoreSix = new string[]{"j","x"};
    public string[] scoreSeven = new string[]{"q","z"};

    public Scrabble(string inputWords)
    {
      _inputWords = inputWords;
    }

    public List<string> SplitWords()
    {
      List<char> _inputList = new List<char>{};
      char[] inputArray = _inputWords.ToLower().ToCharArray();

      foreach (char letter in inputArray)
      {
        _inputList.Add(letter);
      };

      var result = _inputList.Select(c => c.ToString()).ToList();
      return result;
    }

    public int ScoreForA(List<string> result)
    {
      int score = 0;
      foreach(string letter in result)
      {
        for (int i=0; i < scoreOne.Length; i++) {
          if(letter == scoreOne[i])
          {
            score += 1;
          }
        }
        for (int i=0; i < scoreTwo.Length; i++) {
          if(letter == scoreTwo[i])
          {
            score += 2;
          }
      }
        for (int i=0; i < scoreThree.Length; i++) {
          if(letter == scoreThree[i])
          {
            score += 3;
          }
        }
        for (int i=0; i < scoreFour.Length; i++) {
          if(letter == scoreFour[i])
          {
            score += 4;
          }
        }
        for (int i=0; i < scoreFive.Length; i++) {
          if(letter == scoreFive[i])
          {
            score += 5;
          }
        }
        for (int i=0; i < scoreSix.Length; i++) {
          if(letter == scoreSix[i])
          {
            score += 8;
          }
        }
        for (int i=0; i < scoreSeven.Length; i++) {
          if(letter == scoreSeven[i])
          {
            score += 10;
          }
        }

    }
    return score;
  }
}
}
