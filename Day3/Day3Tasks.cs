using System;
using System.Linq;
using Threading;
public class Day3Task {
	public static void Main() {
		Console.WriteLine("################");
		Console.WriteLine("| _         _  |\n|| \\ _.   _ _) |\n||_/(_|\\/   _) |\n|      /\t   |");
		Console.WriteLine("################");
		int choice=0;
		do{
			getChoices();
			Console.Write("Enter your choice: ");
			choice = int.Parse(Console.ReadLine());
			switch(choice){
				case 1:	Ques1();
						break;
				case 2:	Ques2();
						break;
				case 3:	Ques3();
						break;
				case 4:	Ques4();
						break;
				case 5:	Ques5();
						break;
				case 6:	Ques6();
						break;
				case 7:	Ques7();
						break;
				case 8:	Ques8();
						break;
				case 9:	Ques9();
						break;
				case 10:	Ques10();
						break;
				case 11:	Ques11();
						break;
				case 12:	Ques12();
						break;
				case 13:	Ques13();
						break;
				default:	Console.WriteLine("Wrong input, retry!");
							break;
			}
		}
		while(choice <= 13);
		Console.WriteLine("Finished!!");
    }
	public static void getChoices(){
		Console.WriteLine("\n-------------------------------------------------------------");
		Console.WriteLine("Choose from  the menu: ");
		Console.WriteLine("1. Create C# Program to Get 2 Arrays as Input and Produce a 3rd Array by appending one to other.");
		Console.WriteLine("2. Program to find minimum and maximum value of an array.");
		Console.WriteLine("3. Print duplicate characters in a String?");
		Console.WriteLine("4. Reverse a String");
		Console.WriteLine("5. Count number of words in a String");
		Console.WriteLine("6. Check if String is Palindrome");
		Console.WriteLine("7. Remove duplicate characters from String");
		Console.WriteLine("8. Return highest occurred character in a String");
		Console.WriteLine("9. Determine if the string has all unique characters");
		Console.WriteLine("10. Replace all spaces in a string with %20");
		Console.WriteLine("11. Swap two numbers without using a temp variable in C# ");
		Console.WriteLine("12. Write a C# program to calculate factorial using recursion");
		Console.WriteLine("13. Write a C# program to check if the entered number is Armstrong number");
	}
	
	public static void Ques1(){
		int n1,n2;
		Console.Write("Enter the size of array 1: ");
		n1 = int.Parse(Console.ReadLine());
		int[] Arr1 = new int[n1];
		Console.WriteLine("Enter the elements of Array 1: ");
		for(int i=0; i<n1; i++)
			Arr1[i] = int.Parse(Console.ReadLine());
		Console.Write("Enter the size of array 2: ");
		n2 = int.Parse(Console.ReadLine());
		int[] Arr2 = new int[n2];
		Console.WriteLine("Enter the elements of Array 2: ");
		for(int i=0; i<n2; i++)
			Arr2[i] = int.Parse(Console.ReadLine());
		int[] Arr3 = new int[n1+n2];
		for(int i=0; i<(n1+n2); i++){
			if(i<n1)
				Arr3[i] = Arr1[i];
			else
				Arr3[i] = Arr2[i-n1];
		Console.WriteLine("The Appended array is:");
		for(int j=0; j<(n1+n2); j++)
			Console.Write(Arr3[j]+", ");
		}
	}
	
	public static void Ques2(){
		int n, min, max;
		Console.Write("Enter the size of Array: ");
		n = int.Parse(Console.ReadLine());
		int[] Arr = new int[n];
		Console.WriteLine("Enter the elements of Array: ");
		for(int i=0; i<n; i++)
			Arr[i] = int.Parse(Console.ReadLine());
		Array.Sort(Arr);
		min = Arr[0];
		max = Arr[n-1];
		Console.WriteLine("The minimum value of the array is {0} and maximum is {1}",min,max);
	}
	
	public static void Ques3(){
		string s;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		int []Arr = new int[256];		// Each position of array is equivalent to ascii value of char
		for(int i=0; i<s.Length; i++)
			Arr[s[i]]++;				// Position is automatically converted to ASCII int value from char
		for(int i=0; i<Arr.Length; i++)
			if(Arr[i]>1)
				Console.WriteLine("The duplicate charachter {0} is repeated {1} times", Convert.ToChar(i), Arr[i]);
	}
	
	public static void Ques4(){
		string s, S;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		char []Arr = s.ToCharArray();
		Array.Reverse(Arr);
		S = new string(Arr);
		Console.WriteLine("The reversed string is:\n{0}", S);
	}
	
	public static void Ques5(){
		string s;
		char check = ' ';
		int count = 1;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		int l = s.Length;
		for(int i=0; i<l; i++)
			if(s[i] == check)
				count++;
		Console.WriteLine("Total words = "+count);
	}
	
	public static void Ques6(){
		string s;
		bool flag = true;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		int l = s.Length;
		for(int i=0; i<l; i++)
			if(s[i] != s[l-1-i])
				flag = false;
		Console.WriteLine("Palindrome check for the given string: {0} came out to be: \"{1}\"", s, flag);
	}
	
	public static void Ques7(){
		string s;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		int []Arr = new int[256];		// Each position of array is equivalent to ascii value of char
		int dupl = 0, start=-1;
		for(int i=0; i<s.Length; i++)
			Arr[s[i]]++;				// Position is automatically converted to ASCII int value from char
		for(int i=0; i<Arr.Length; i++)
			if(Arr[i]>1)
				dupl++;					// To find the no. of duplicate items
		char []dupArr = new char[dupl];	// Array with a length of duplicate no of items
		for(int i=0; i<Arr.Length; i++)
			if(Arr[i]>1)
				dupArr[++start] = Convert.ToChar(i);
		for(int i=0; i<dupl; i++)
			s = s.Replace(dupArr[i], ' ');
		Console.WriteLine(s.Replace(" ",""));
	}
	
	public static void Ques8(){
		string s;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		int []Arr = new int[256];
		for(int i=0; i<s.Length; i++)
			Arr[s[i]]++;
		int max, pos;
		max = Arr.Max();
		pos = Array.IndexOf(Arr, max);
		Console.WriteLine("The highest occured charachter is {0} which occured {1} times", Convert.ToChar(max), pos);
	}
	
	public static void Ques9(){
		string s;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		int []Arr = new int[256];
		for(int i=0; i<s.Length; i++)
			Arr[s[i]]++;
		bool flag = true;
		for(int i=0; i<Arr.Length; i++)
			if(Arr[i]>1)
				flag = false;
		if(flag)
			Console.WriteLine("The string is not unique");
		else
			Console.WriteLine("The string unique");
	}
	
	public static void Ques10(){
		string s;
		Console.WriteLine("Enter a string: ");
		s = Console.ReadLine();
		Console.WriteLine(s.Replace(" ", "%20"));
	}
	
	public static void Ques11(){
		int a,b;
		Console.Write(" A = ");
		a = int.Parse(Console.ReadLine());
		Console.Write(" B = ");
		b = int.Parse(Console.ReadLine());
		Console.WriteLine("Originally:\nA = {0} and B = {1}", a, b);
		// swapping
		a = a+b;
		b = a-b;
		a = a-b;
		Console.WriteLine("After Swapping:\nA = {0} and B = {1}", a, b);
	}
	
	public static void Ques12(){
		int num;
		Console.Write("Enter number = ");
		num = int.Parse(Console.ReadLine());
		Console.WriteLine("Factorial of {0} is: {1}", num, factorial(num));
	}
	// Connected method.......
	private static int factorial(int num){
		if(num >= 1)
			return num*factorial(num-1);
		else
			return 1;
	}
	
	public static void Ques13(){
		int num, rem, sum = 0, temp;
		Console.Write(" A = ");
		num = int.Parse(Console.ReadLine());
		temp = num;
		while(num>0){
			rem = num%10;
			sum += rem*rem*rem;
			num /= 10;
		}
		if(temp == sum)
			Console.WriteLine("The given number {0} is an Armstrong number", temp);
		else
			Console.WriteLine("The given number {0} is NOT an Armstrong number", temp);
	}
}
