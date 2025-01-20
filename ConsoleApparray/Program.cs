using System;

class Program
{
    static void Main()
    {
        // how many numbers
        Console.Write("How many numbers do you want to process? ");
        int count = int.Parse(Console.ReadLine());

        // store numbers from array
        int[] numbers = new int[count];

        // input data
        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // calculate sum and find the smallest number on the input datas
        int sum = 0;
        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest) largest = number;
            if (number < smallest) smallest = number;
        }

        // display all the results
        Console.WriteLine($"\nSum of all numbers: {sum}");
        Console.WriteLine($"Largest number: {largest}");
        Console.WriteLine($"Smallest number: {smallest}");
        Console.ReadLine(); 
    }
}