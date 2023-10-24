Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool - true / false
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"CPU is {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if(userNumber == cpuRandom)
    { Console.WriteLine("Congrats! You won!");
        //loopActive = false;
        break;
    }
    else
    { Console.WriteLine("Uups! Try again"); }

}
Console.WriteLine("Have a nice day");