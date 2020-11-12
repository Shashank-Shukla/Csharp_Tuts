using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Day1Tasks
{
  public static void Main()
  {
    int choice = 1;
    Console.WriteLine("______               __ ");
    Console.WriteLine("|  _  |             /  | ");
    Console.WriteLine("| | | |__ _ _   _   `| | ");
    Console.WriteLine("| | | / _` | | | |   | |");
    Console.WriteLine("| |/ / (_| | |_| |  _| |_");
    Console.WriteLine("|___/ {__,_|-__, | |____|");
    Console.WriteLine("             __/ |   ");
    Console.WriteLine("            |___/   ");
    Console.WriteLine("============================================================");
    do{
      choiceList();
      choice = int.Parse(Console.ReadLine());
      switch(choice){
          case 1:   Question1();
                    contd(ref choice);
                    break;
          case 2:   Question2();
                    contd(ref choice);
                    break;
          case 3:   Question3();
                    contd(ref choice);
                    break;
          case 4:   Question4();
                    contd(ref choice);
                    break;
          case 5:   Question5();
                    contd(ref choice);
                    break;
          case 6:   Question6();
                    contd(ref choice);
                    break;
          case 7:   Question7();
                    contd(ref choice);
                    break;
          case 8:   Question8();
                    contd(ref choice);
                    break;
          default: Console.WriteLine("Wrong choice!! Kindly re-enter a choice between 0 to 9!!;");
                    Thread.Sleep(3000);
                    break;
      }
    }
    while(choice != 9);
    Console.Write("Exiting....");
  }
  
  public static void choiceList(){
      Console.WriteLine("######################################");
      Console.WriteLine("Solve the problems from this menu!!::::");
      Console.WriteLine("1. Write a C# program that accepts 2 numbers and prints the smaller number");
      Console.WriteLine("2. Convert above program to use function (function to accepts 2 numbers and returns small no)");
      Console.WriteLine("3. Write a C# function to find whether a given number is prime. It should returns a Boolean true if the number if prime, else returns Boolean false");
      Console.WriteLine("4. Write C# function to find position of the first prime number in a given array. Use the above function to decide a number is prime or not");
      Console.WriteLine("5. Write C# function to find biggest prime number in a given array");
      Console.WriteLine("6. Modify Q2 to so that it returns both the position and also the number");
      Console.WriteLine("7. Accept a string from the user and return the count of vowels in the string");
      Console.WriteLine("8. Accept a string from the user and return count of words");
      Console.WriteLine("9. Exit!");
      Console.Write("Enter a Choice: ");
  }
  
  //----------------- Continuation Choice -----------------
  public static void contd(ref int choice){
      Console.Write("Wanna continue (y/n): ");
      char c = char.Parse(Console.ReadLine());
      if((c=='n')||(c=='N'))
        choice = 9;
      Console.WriteLine();
  }
  
  //----------------- Wait a bit -----------------
  public static void wait2sec(){
      Console.WriteLine("------------------------------ X ---------------------------------");
      Console.WriteLine();
      Thread.Sleep (2000);      // 2 sec sleep timer
  }
  
  //----------------- Question 1 -----------------
  public static void Question1(){
      int a,b;
      Console.WriteLine("Kindly enter 2 integers to compare!!");
      Console.Write("A = ");
      a = int.Parse(Console.ReadLine());
      Console.Write("B = ");
      b = int.Parse(Console.ReadLine());
      if(a<b)
        Console.WriteLine($"The number A ({a}) is smaller than B ({b})");
      else
        Console.WriteLine($"The number B ({b}) is smaller than A ({a})");
      wait2sec();
  }
  
  //----------------- Question 2 -----------------
  public static void Question2(){
      int a=0, b=0, smol;
      smol = func4_Q2(ref a, ref b);        // Solved using the reference method
      Console.WriteLine($"The smaller number out of {a} and {b} is {smol}");
      wait2sec();
  }
  //  ||connected to previous function||  \\
  private static int func4_Q2(ref int a, ref int b){
      Console.WriteLine("Kindly enter 2 integers to compare!!");
      Console.Write("A = ");
      a = int.Parse(Console.ReadLine());
      Console.Write("B = ");
      b = int.Parse(Console.ReadLine());
      if(a<b)
        return a;
      else
        return b;
  }
  
  //----------------- Question 3 -----------------
  public static void Question3(){
      Console.Write("Kindly enter a number to check if it's a prime: ");
      int a = int.Parse(Console.ReadLine());
      bool result;              //  Solved using the out method
      isPrine(a, out result);
      Console.WriteLine($"The test for number {a} to be prime came out to be {result}.");
      wait2sec();
  }
  //  ||connected to previous function||  \\
  private static void isPrine(int a, out bool result){
      result = true;
      if((a==1)||(a==2))
        result = false;
      else
        for(int i=2; i<a/2; i++)
            if(a%i == 0)
                result = false;
  }
  
  //----------------- Question 4 -----------------
  public static void Question4(){
      int size, pos = 0;
      bool flag = false;
      Console.Write("Kindly specify the size of array: ");
      size = int.Parse(Console.ReadLine());
      int[] A = new int[size];
      Console.WriteLine("Please enter the array elements below!");
      for(int i=0; i<size; i++){
          Console.Write($"Element {i+1} = ");
          A[i] = int.Parse(Console.ReadLine());
      }
      for(int i=0; i<size; i++){
          isPrine(A[i], out flag);
          pos = i+1;
          if(flag)
            break;
      }
      if(!flag)
        Console.WriteLine("No prime numbers found in the given array");
      else
        Console.WriteLine($"The first prime number occured at {pos} is {A[pos-1]}");
      wait2sec();
  }
  
  //----------------- Question 5 -----------------
  public static void Question5(){
      // Option 1: Loop through each element and check if it's prime and the biggest number.
            //      Time Complexity: O(n*n!)
      // Option 2:
      //        Step-1: Sort the array
      //        Step-2: Find 1st prime number from the back.
            //      Time Complexity: O(2n)
      int size, pos = 0;
      bool flag = false;
      Console.Write("Kindly specify the size of array: ");
      size = int.Parse(Console.ReadLine());
      int[] A = new int[size];
      Console.WriteLine("Please enter the array elements below!");
      for(int i=0; i<size; i++){
          Console.Write($"Element {i+1} = ");
          A[i] = int.Parse(Console.ReadLine());
      }
      // Sorting.....
      Array.Sort(A);
      for(int i=size-1; i>=0; i--){
          isPrine(A[i], out flag);
          pos = i+1;
          if(flag)
            break;
      }
      if(!flag)
        Console.WriteLine("No prime numbers found in the given array");
      else
        Console.WriteLine($"The first prime number occured at {pos-1} is {A[pos-1]}");
      wait2sec();
  }
  
  //----------------- Question 6 -----------------
  public static void Question6(){
      // Redirecting to Question 5 as I already designed it ealier.
      Question5();
  }
  
  //----------------- Question 7 -----------------
  public static void Question7(){
      string s, str;
      Console.WriteLine("Kindly enter the string below!");
      s = Console.ReadLine();       // Keeping original string and
      str = s.ToLower();            // Making a copy of it with all lowecase
      char[] cArray = str.ToCharArray();
      char[] vowels = {'a', 'e', 'i', 'o', 'u'};
      //char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
      int total=0;
      foreach(char i in cArray)
        //if(Array.Find(vowels, element => element.Contains(i)))
        foreach(char c in vowels)
            if(i==c)
                total++;
      Console.WriteLine($"There are {total} Vowels in the given string");
      wait2sec();
  }
  
  //----------------- Question 8 -----------------
  public static void Question8(){
      string str;
      Console.WriteLine("A word is considered if a space is encountered or a full-stop(.) or comma (,) following with a space.");
      Console.WriteLine("Kindly enter a sentence below!");
      str = Console.ReadLine();
      char[] cArray = str.ToCharArray();
      int total=0;
      for(int i=0; i<str.Length; i++)       // Word end = ', ' '. ' or ' #' where # is a char.
          if(((cArray[i] == '.')&&(cArray[i+1] == ' '))||
            ((cArray[i] == ',')&&(cArray[i+1] == ' '))||
            ((cArray[i] == ' ')&&(cArray[i+1] != ' '))){
                total++;
                i++;
            }
      Console.WriteLine($"There are {total+1} words in the given string");
      wait2sec();
  }
}
