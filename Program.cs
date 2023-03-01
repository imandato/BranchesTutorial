
int a = 5;
//int b = 6;
//modify the declaration of b so that the answer is less than 10
int b = 3;

int c = 4;

if ((a + b + c > 10) && (a==b))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("Or the first number is not equal to the second");
}

if ((a + b + c > 10) || (a==b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}
