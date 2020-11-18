using System;
class Program {
  static void Main() {
    Console.WriteLine("WAP to guess my number");
    Random r = new Random();
    int no = r.Next(1,200);
    Console.WriteLine(no);
    int guess,chance=0;
    do{
        if (chance == 0)
            Console.WriteLine("Guess a number!! ");
        else
            Console.WriteLine("Oops, Retry! ");
        guess = int.Parse(Console.ReadLine());
        if(guess > 10*no)
            Console.WriteLine("Your guess was too high");
        else if(guess > no)
            Console.WriteLine("Your guess was close but high");
        else if(guess < 10*no)
            Console.WriteLine("Your guess was too low");
        else if(guess < no)
            Console.WriteLine("Your guess was too low");
        chance++;
    }
    while(guess != no);
    Console.WriteLine("Correct, you made the right guess in "+chance+" attempts");
  }
}
