using System;
using System.Collections.Generic;
using Xunit;

namespace ScrabbleGame
{
  public class ScrabbleTest
  {
  [Fact]
  public void SplitWords_UsersInputWords_SplittedCharacters()
  {
    //Arrange
    string inputWords = "dog";
    Scrabble testScrabble = new Scrabble(inputWords);
    List<string> outputString = testScrabble.SplitWords();
    //Act
    List<string> verifyString = new List<string> {"d","o","g"};
    //Assert
    Assert.Equal(outputString,verifyString);
  }
  [Fact]
  public void SplitWords_UsersInputWords_true()
  {
    //Arrange
    string inputWords = "cat";
    Scrabble testScrabble = new Scrabble(inputWords);
    List<string> outputString = testScrabble.SplitWords();
    //Assert
    Assert.Equal(true,testScrabble.ContainsA(outputString));
  }

  }
}
