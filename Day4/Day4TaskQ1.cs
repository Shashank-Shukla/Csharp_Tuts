using System; 

interface Icar 
{  
	void Price(); 
} 

// A class that implements interface. 
class Car1 : Icar 
{
  private string price = "1 Gazillion Aanas";
	// providing the car price 
	public void Price() 
	{ 
		Console.WriteLine("Price = "+price); 
	} 
}

class Car2 : Icar 
{
  private string price = "1 Trillion Lives";
	// providing the car price 
	public void Price() 
	{ 
		Console.WriteLine("Price = "+price); 
	} 
}
class Car3 : Icar 
{
  private string price = "5 Rupees";
	// providing the car price 
	public void Price() 
	{ 
		Console.WriteLine("Price = "+price); 
	} 
}
class Program{
	// Main Method 
	public static void Main (String []args) 
	{ 
		Icar ob;
    Console.Write("Price for:\n1. Car1\n2. Car2\n3. Car3 : ");
    int choice = int.Parse(Console.ReadLine());
    switch(choice){
      case 1: ob = new Car1();
              ob.Price();
              break;
      case 2: ob = new Car2();
              ob.Price();
              break;
      case 3: ob = new Car3();
              ob.Price();
              break;
      
    }
	} 
} 
