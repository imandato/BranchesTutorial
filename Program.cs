﻿




ExploreIf();
ExploreLoops();

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello World! The counter is {counter}");
//    //++ increment operator - adds one to value if counter and stores value in counter variable
//    counter++;
//}



void ExploreLoops()
{
    int counter = 0;
    do
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    } while (counter < 10);


    for (int index = 0; index < 10; index++)
    {
        Console.WriteLine($"Hello World! The index is {index}");
    }

    for (int index = 3; index < 20; index++)
    {
        Console.WriteLine($"Hello World! The index is {index}");
    }

    //create matrix
    for (int row = 1; row < 11; row++)
    {
        //Console.WriteLine($"The row is {row}");
        for (char column = 'a'; column < 'k'; column++)
        {
            //Console.WriteLine($"The column is {column}");
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }

}



void ExploreIf()
{
    int a = 5;
    //int b = 6;
    //modify the declaration of b so that the answer is less than 10
    int b = 3;

    int c = 4;

    if ((a + b + c > 10) && (a == b))
    {
        Console.WriteLine("The answer is greater than 10.");
        Console.WriteLine("And the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10.");
        Console.WriteLine("Or the first number is not equal to the second");
    }

    if ((a + b + c > 10) || (a == b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is equal to the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not equal to the second");
    }
}

//Combine Branches and Loops Challenge
int count = 0;
for (int index=1; index<21; index++)
{
    if (index % 3 == 0){
        count = count + index;
        Console.WriteLine($"The sum is {count}");
    }
}