using System;
public class Program
{
	enum grade {A=3, B=6, C=8, D};
	public static void Main()
	{
		Console.WriteLine("WAP to grade employees based on thier salary");
    Console.WriteLine("Enter Employee Salary: ");
		int sal = int.Parse(Console.ReadLine());
		if (sal <= (int)grade.A)
			Console.WriteLine("Grade-A");
		else if (sal <= (int)grade.B)
			Console.WriteLine("Grade-B");
		else if (sal <= (int)grade.C)
			Console.WriteLine("Grade-C");
		else
			Console.WriteLine("Grade-D");
	}
}
