using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a for money exchange or b for temperature converter");
        string answer1 = Console.ReadLine();
        if(answer1 == "a")
        {
            Console.WriteLine("select a to convert from AUD to MXN or b to convert from MXN to AUD");
            string answer2 = Console.ReadLine();

            if(answer2 == "a")
            {
                Console.WriteLine("how many AUD?");
                float AUD = float.Parse(Console.ReadLine());
                Console.WriteLine("You have " +  (AUD * 11.3f) + " Mexican pesos");
            }
            else if(answer2 == "b") 
            {
                Console.WriteLine("how many MXN?");
                float MXN = float.Parse(Console.ReadLine());
                Console.WriteLine("You have " + (MXN * 0.089f) + " Australian Dollars");
            }
            else
            {
                Console.ReadLine();
            }
        }
        else if(answer1 == "b") 
        {
            Console.WriteLine("Press a for celsius to fahrenheit or b for fahrenheit to calsius");
            string answer3 = Console.ReadLine();

            if(answer3 == "a")
            {
                Console.WriteLine("Log the temperature you want to convert");
                float celsius = float.Parse(Console.ReadLine());

                Console.WriteLine(celsius + " celsius is equal to " + ((celsius * 9 / 5) + 32) + " farenheid");
            }
            else if (answer3 == "b")
            {
                Console.WriteLine("Log the temperature you want to convert");
                float farenheit = float.Parse(Console.ReadLine());

                Console.WriteLine(farenheit + " farenheit is equal to " + ((farenheit -32) * 5/9) + " celsius");
            }
        }
    }
}