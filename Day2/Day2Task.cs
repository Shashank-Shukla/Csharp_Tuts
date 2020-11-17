using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Q1{
    private string name, address;
    
    public Q1(string name, string address){
        Console.Write("Enter your name here: ");
        name = Console.ReadLine();
        Console.Write("Enter your address here: ");
        address = Console.ReadLine();
        this.name = name;
        this.address = address;
    }
    
    private string getName(){
        return name;
    }
    
    private string getAddress(){
        return address;
    }
    
    public void printDetails(){
        Console.WriteLine($":::User Details:::\nName:\t{name}\nAddress:\t{address}");}
}

//employee rollno, name, address, pin code, phone number, gross salary and pf. 
//Display the net salary (ie gross less pf) and calculate grade base on net salary. 
//The grades are: Grade-‘A’ sal>10000  Grade-‘B’ sal>5000  Grade-‘C’ sal<5000
class emp{
    private string empName;
    private int empRNo, pinCode, grossSal, pf;
    private long phNo;
    public emp(){
        /*private string empName;
        private int empRNo, pinCode, grossSal, pf;
        private long phNo;*/
        Console.WriteLine("[INFO]:: Details inputs successful");
    }
    
    public void getDetails(){
        Console.Write("Enter the employee's Name         : ");
        empName = Console.ReadLine();
        Console.Write("Enter the employee's Roll No.     : ");
        empRNo = int.Parse(Console.ReadLine());
        Console.Write("Enter the employee's Pin code     : ");
        pinCode = int.Parse(Console.ReadLine());
        Console.Write("Enter the employee's gross salary : ");
        grossSal = int.Parse(Console.ReadLine());
        Console.Write("Enter the employee's PF amount    : ");
        pf = int.Parse(Console.ReadLine());
        Console.Write("Enter the Employee's Phone Number :");
        phNo = long.Parse(Console.ReadLine());
    }
    
    private char Grade(int netSal){
        if(netSal >= 10000)
            return 'A';
        else if(netSal >= 5000)
            return 'B';
        else
            return 'C';
    }
    
    /*private int netSal(int grossSal, int pf){
        return Grade(grossSal-pf);
    }*/
    
    public void printDetails(){
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("[INFO]:: Employee details are as follows:");
        Console.WriteLine($"[INFO]:: Name        : {empName}\n[INFO]:: R.No.       : {empRNo}\n[INFO]:: Pin-Code     : {pinCode}\n[INFO]:: Phone-number: {phNo}\n[INFO]:: Gross-Salary: {grossSal}\n[INFO]:: PF           : {pf}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"[INFO]:: Employee's Grade :\t{Grade(grossSal-pf)}");
    }
}

class Day2Tasks {
  static void Main() {
    Console.WriteLine("+===============================+");
    Console.WriteLine("|  _____                ___     |");
    Console.WriteLine("| |  __ \\              |__ \\    |");
    Console.WriteLine("| | |  | | __ _ _   _     ) |   |");
    Console.WriteLine("| | |  | |/ _` | | | |   / /    |");
    Console.WriteLine("| | |__| | (_| | |_| |  / /_    |");
    Console.WriteLine("| |_____/ \\__,_|\\__, | |____|   |");
    Console.WriteLine("|                __/ |          |");
    Console.WriteLine("|               |___/           |");
    Console.WriteLine("-===============================-");
    Console.WriteLine();
    int choice = 0;
    string options = "Solve the problems from this menu!!::::\n1. Write a program to accept the name and address from the user and display it. \n2. Write a program to display all the ASCII values. (Hint: use ToChar ())\n3. Write a program to print all the even number from 1 to 50.\n4. Write a program that repeatedly prompts the user to input a negative or positive number, and then echoes it. When the value 0 is entered, the program should terminate and should print the total number of odd, even, positive and negative numbers that are entered before terminating.\n5. Write a program using for loop that examines all the numbers between 2 and 1000, and display only Perfect numbers.\n6. Write a program to accept an array of integers (10) and sort them in ascending order.\n7. Write program to find whether a given number if prime or not by means of a user defined method “prime”, which returns a Boolean true if the number if prime, else returns Boolean false.\n8. Write a program using structures that will get input regarding name, sex, height, weight and displays the information that is got from the user.\n9. Write a program using a class that get information about employee rollno, name, address, pin code, phone number, gross salary and pf. Display the net salary (ie gross less pf) and calculate grade base on net salary. The grades are:\n\tGrade-‘A’ sal>10000\n\tGrade-‘B’ sal>5000\n\tGrade-‘C’ sal<5000\n10. Exit\nEnter your Choice: ";
    do{
        Console.WriteLine("######################################");
        Console.Write(options);
        choice = int.Parse(Console.ReadLine());
        switch(choice){
            case 1:     Question1();
                        contd(ref choice);
                        break;
            case 2:     Question2();
                        contd(ref choice);
                        break;
            case 3:     Question3();
                        contd(ref choice);
                        break;
            case 4:     Question4();
                        contd(ref choice);
                        break;
            case 5:     Question5();
                        contd(ref choice);
                        break;
            case 6:     Question6();
                        contd(ref choice);
                        break;
            case 7:     Question7();
                        contd(ref choice);
                        break;
            case 8:     Question8();
                        contd(ref choice);
                        break;
            case 9:     Question9();
                        contd(ref choice);
                        break;
            case 10:    break;
            default:    Console.WriteLine("Wrong choice!! Kindly re-enter a choice between 0 to 10!!;");
                        Thread.Sleep(1500);
                        break;
            
        }
    }
    while((choice < 10)&&(choice>=0));
    Console.WriteLine("Exiting !!!");
  }
  
  // Definition of Continuation block
  private static void contd(ref int choice){
        Console.Write("\nWanna continue (y/n): ");
        char c = char.Parse(Console.ReadLine());
        if((c=='n')||(c=='N'))
            choice = 10;
        Console.WriteLine();
  }
  
  // Definition of Question-1
  private static void Question1(){
        /*  Without using class!
        string name, address;
        Console.Write("Enter your name here: ");
        name = Console.ReadLine();
        Console.Write("Enter your address here: ");
        address = Console.ReadLine();
        Console.WriteLine($":::User Details:::\nName:\t{name}\nAddress:\t{address}");
        */
        // Using abstraction (classes)
        Q1 ob = new Q1("", "");
        ob.printDetails();
  }
  
  // Definition of Question-2
  private static void Question2(){
        Console.WriteLine("Printing the ASCII values:");
        Thread.Sleep(2000);
        for(int i=0; i<256; i++)
            Console.WriteLine($"The ASCII value of {i} is {Convert.ToChar(i)}");
  }
  
  // Definition of Question-3
  private static void Question3(){
        Console.WriteLine("Even numbers til 50: ");
        for(int i=1; i<=50; i++)
            if(i%2 == 0)
                Console.Write($"{i}, ");
  }
  
  // Definition of Question-4
  private static void Question4(){
        int v=1, posCount=0, negCount=0, oddCount=0, evenCount=0;
        while(v != 0){
            Console.Write("Enter the value: ");
            v = int.Parse(Console.ReadLine());
            if(v<0)
                negCount++;
            else if(v>0)
                posCount++;
            if(v%2 == 0)
                evenCount++;
            else
                oddCount++;
        }
        Console.WriteLine($"\t::--[Stats]--::\nTotal even numbers entered: {evenCount-1}\nTotal odd numbers entered: {oddCount}\nTotal negative numbers entered: {negCount}\nTotal positive numbers entered: {posCount}");
  }
  
  // Definition of Question-5
  private static void Question5(){
        int min = 2, max = 10000, sum;
        Console.WriteLine("Perfect Number are numbers whose sum of divisors equals the number itself.");
        Console.WriteLine($"Perfect numbers in the range of {min} and {max} are:");
        for(int i=min; i<=max; i++){
            sum=0;
            for(int j=1; j<i; j++)
                if(i%j == 0)
                    sum += j;
            if(sum == i)
                Console.Write($"{i} ");
        }
        
  }
  
  // Definition of Question-6
  private static void Question6(){
        int n, temp;
        Console.Write("Enter the size of Array: ");
        n = int.Parse(Console.ReadLine());
        int[] Arr = new int[n];
        Console.WriteLine("Enter the array elemts:");
        for(int i=0; i<n; i++)
            Arr[i] = int.Parse(Console.ReadLine());
        Array.Sort(Arr);        // Using Array.Sort() method
        Console.WriteLine("Array sorted using Array.Sort() method:");
        for(int i=0; i<n; i++)
            Console.Write($"{i} ");
        Console.WriteLine("\nArray sorted using Insertion Sort algorithm:");
        for(int i=0; i<n; i++)
            for(int j=i+1; j<n; j++)
                if(Arr[i] < Arr[j]){
                    temp = Arr[i];
                    Arr[i] = Arr[j];
                    Arr[j] = Arr[i];
                }
        foreach(int i in Arr)
            Console.Write(i+" ");
  }
  
  // Definition of Question-7
  private static void Question7(){
        int n;
        Console.Write("Enter a number to check if it's prime or not: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine($"The satement about {n} being prime came out to be: {prime(n)}");
  }
        // -----Connected method-----
    private static bool prime(int n){
        for(int i=2; i<n/2; i++)
            if(n%i == 0)
                return false;
        return true;
    }
  
  // Definition of Question-8
  private static void Question8(){
        Console.WriteLine("Error 404! \nTry another question!");
        
  }
  
  // Definition of Question-9
  private static void Question9(){
        emp ob = new emp();
        ob.getDetails();
        ob.printDetails();
  }
}
