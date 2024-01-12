// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");

int number = Convert.ToInt32(Console.ReadLine());

long fact = GetFactorial(number);

Console.WriteLine("{0} factorial are {1}", number, fact);

Console.ReadKey();

 static long GetFactorial(int number)

{

    if (number == 0)

    {

        return 1;

    }

    return number * GetFactorial(number - 1);

}