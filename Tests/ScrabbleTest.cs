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
  public void SplitWords_UsersInputWords_ReturnScoreOne()
  {
    //Arrange
    string inputWords1 = "tan";
    Scrabble testScrabble = new Scrabble(inputWords1);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 3;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }
  [Fact]
  public void SplitWords_UsersInputWords_ReturnScoreTwo()
  {
    //Arrange
    string inputWords2 = "lime";
    Scrabble testScrabble = new Scrabble(inputWords2);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 3;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }
  [Fact]
  public void SplitWords_UsersInputWords_ReturnScoreThree()
  {
    //Arrange
    string inputWords3 = "pine";
    Scrabble testScrabble = new Scrabble(inputWords3);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 6;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }
  [Fact]
  public void SplitWords_UsersInputWords_ReturnScoreFour()
  {
    //Arrange
    string inputWords4 = "kiwi";
    Scrabble testScrabble = new Scrabble(inputWords4);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 6;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }
  [Fact]
  public void SplitWords_UsersInputWords_ReturnScoreFive()
  {
    //Arrange
    string inputWords5 = "cake";
    Scrabble testScrabble = new Scrabble(inputWords5);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 10;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }
  [Fact]
  public void SplitWords_UsersInputWords_ReturnScoreSix()
  {
    //Arrange
    string inputWords5 = "jax";
    Scrabble testScrabble = new Scrabble(inputWords5);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 17;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }
  [Fact]
  public void SplitWords_UsersInputWords_ReturnScoreSeven()
  {
    //Arrange
    string inputWords5 = "quiz";
    Scrabble testScrabble = new Scrabble(inputWords5);
    List<string> outputString = testScrabble.SplitWords();
    int outputScore = testScrabble.ScoreForA(outputString);
    //Act
    int verifyScore = 22;
    //Assert
    Assert.Equal(verifyScore, outputScore);
  }

  }
}
