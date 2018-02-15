using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace Scrabble.Models
{
  public class ScrabbleScore
  {
    private string _word;
    private int _score;

    public ScrabbleScore (string word)
    {
      _word = word;
      _score = 0;
    }

    public string GetWord()
    {
      return _word;
    }

    public int GetScore()
    {
      return _score;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

    public void SetScore()
    {
      string upperWord = _word.ToUpper();
      char[] wordArray = upperWord.ToCharArray();
      char[] scoreOneArray = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
      char[] scoreTwoArray = {'D', 'G'};
      char[] scoreThreeArray = {'B', 'C', 'M', 'P'};
      char[] scoreFourArray = {'F', 'H', 'V', 'W', 'Y'};
      char[] scoreFiveArray = {'K'};
      char[] scoreEightArray = {'J', 'X'};
      char[] scoreTenArray = {'Q', 'Z'};
      foreach (char letter in wordArray)
      {
        if (scoreOneArray.Contains(letter))
        {
          _score++;
        }
        else if (scoreTwoArray.Contains(letter))
        {
        _score += 2;
        }
        else if (scoreThreeArray.Contains(letter))
        {
        _score += 3;
        }
        else if (scoreFourArray.Contains(letter))
        {
        _score += 4;
        }
        else if (scoreFiveArray.Contains(letter))
        {
        _score += 5;
        }
        else if (scoreEightArray.Contains(letter))
        {
          _score += 8;
        }
        else if (scoreTenArray.Contains(letter))
        {
          _score += 10;
        }
      }
    }
  }
}
