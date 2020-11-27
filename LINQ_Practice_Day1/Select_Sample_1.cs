using System;
using System.Collections.Generic;
using System.Linq;
namespace linqDay1{
  class Program{
    static void Main(){
      int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
      string[] cities = {"Delhi", "NY", "London", "NZ", "Australia"};
      var numPlus1 = numbers.Select(n => n+1);
      var str1 = cities.Select(m => m);
      Console.WriteLine("Incremented numbers are: ");
      foreach (int i in numPlus1)
        Console.Write(i+" ");
      Console.WriteLine("Cities are: ");
      foreach (string i in str1)
        Console.Write(i+" ");
    }
  }
}
