
int sum = 0;

for (int i = 0; i < 10; i++ ) // i-- = i-1
{
    
    Console.WriteLine($"i equals {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum +=i
}
//Console.WriteLine($"Finald total {sum}");