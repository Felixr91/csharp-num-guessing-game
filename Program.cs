using System;

namespace guessgame
{
  class Program
  {
    static void Main(string[] args)
    {
      int secret;
      bool won = false;


      Console.WriteLine("Can you guess the secret number?");
      Random rnd = new Random();
      secret = rnd.Next(1, 10);
      Console.WriteLine(secret);

      while (!won)
      {

        string guessString = Console.ReadLine();
        int guess;
        if (Int32.TryParse(guessString, out guess))
        {
          if (guess == secret)
          {
            Console.WriteLine("You got it, dog!");
            won = true;
          }
          else if (guess > secret)
          {
            Console.WriteLine("Guess lower, dog!");
          }
          else if (guess < secret)
          {
            Console.WriteLine("Gotta guess higher, dog!");
          }
        }
        else
        {
          Console.WriteLine("Stop playing! Give me a number!");
        }
      }
    }
  }
}
