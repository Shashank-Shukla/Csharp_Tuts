using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void change(ref int a, ref int b){
    b = a+b;
  }
  public static void Main()
  {
    int a,b;
    Console.Write("A = ");
    a = int.Parse(Console.ReadLine());
    Console.Write("B = ");
    b = int.Parse(Console.ReadLine());
    change(ref a, ref b);
    Console.Write($"A = {a}, B = {b}");
  }
}
