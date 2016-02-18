using System.Collections.Generic;
using System;

namespace ScrabbleScore.Objects
{
  public class ScrabbleScore
  {


    public ScrabbleScore()
    {

    }

    public static int ScoreWord(string input)
    {
      Dictionary<char, int> testDictionary = new Dictionary<char, int> {};
      testDictionary.Add('a', 1);
      testDictionary.Add('e', 1);
      testDictionary.Add('i', 1);
      testDictionary.Add('o', 1);
      testDictionary.Add('u', 1);
      testDictionary.Add('l', 1);
      testDictionary.Add('n', 1);
      testDictionary.Add('r', 1);
      testDictionary.Add('s', 1);
      testDictionary.Add('t', 1);

      testDictionary.Add('d', 2);
      testDictionary.Add('g', 2);

      testDictionary.Add('b', 3);
      testDictionary.Add('c', 3);
      testDictionary.Add('m', 3);
      testDictionary.Add('p', 3);

      testDictionary.Add('f', 4);
      testDictionary.Add('h', 4);
      testDictionary.Add('v', 4);
      testDictionary.Add('w', 4);
      testDictionary.Add('y', 4);

      testDictionary.Add('k', 5);

      testDictionary.Add('j', 6);
      testDictionary.Add('x', 6);

      testDictionary.Add('q', 7);
      testDictionary.Add('z', 7);

      int score = 0;

      char[] inputArray = input.ToCharArray();
      for (int i = 0; i < inputArray.Length; i++) {
        foreach ( KeyValuePair<char, int> test in testDictionary) {
          if( inputArray[i] == test.Key)
          {
            score += test.Value;
          }
        }
      }

      return score;
    }
  }
}
