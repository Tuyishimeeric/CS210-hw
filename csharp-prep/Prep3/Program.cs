using System;

Random random = new Random();
int randomnumber = random.Next(1,100);

Console.WriteLine("What is your guess number between 1 annd 100");
int guessnnum = 0;
int attempts = 0;

while (guessnnum != randomnumber )
{
   Console.WriteLine("What is your guess number: "); 
   guessnnum = int.Parse(Console.ReadLine());
   attempts++;

if (guessnnum > randomnumber)
{
    Console.WriteLine(" your guess is Higher");
}
else if(guessnnum < randomnumber)
{
  Console.WriteLine("you guess is Lower");
}
}
Console.WriteLine("Congratulation!!! you guessed right! you should buy yourself a cake!");
Console.WriteLine($"it took you : {attempts}  attempts to guess the number");