string userPIN;
int triesUsed = 0;
while (triesUsed != 3) 
{
    Console.WriteLine("Enter your PIN");
    userPIN = Console.ReadLine();
    if (
  userPIN == "1234")
    {
        Console.WriteLine("Welcome!");
        triesUsed = 3; //number
    }

    else
    {
        Console.WriteLine($"Wrong PIN. Try again. {3 - triesUsed} tries left.");

       triesUsed ++;
    }
}

for (int i = 3; i > 0; i--)
{
    Console.WriteLine("Hello, World!");
}

for (int i = 1; i < 5; i++)
{
    Console.WriteLine("Don't worry, be happy :)");
}

string userPin;
Console.WriteLine("Enter your PIN");
userPIN = Console.ReadLine();
while (true)
{
    if (userPIN == "1234")
    {
        Console.WriteLine("Welcome!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong PIN. Try again.");
    }
}