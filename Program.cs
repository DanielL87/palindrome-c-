using System;
using System.Collections.Generic;

namespace Palindrome {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please Enter a Word");
      string word = Console.ReadLine();
      char [] charArray = word.ToCharArray();
      Array.Reverse(charArray);
      string wordReverse = string.Join("",charArray);
      // string wordReverse = new string(charArray);

      if(word == wordReverse){
        Console.WriteLine("This is a Palindrome");
      }else {
        Console.WriteLine("This is not a Palindrome");
      }
    }
  }
}
