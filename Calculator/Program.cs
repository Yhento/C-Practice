// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input the second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers? ");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiple");

string choice = Console.ReadLine();

if (EqualsCaseInsensitive(choice, "A")) 
{
    
    int result = num1 + num2;
    printResult(num1, "+", num2, result);

}
else if (EqualsCaseInsensitive(choice, "S"))
{
    int result = num1 - num2;
    printResult(num1, "-", num2, result);
}
else if (EqualsCaseInsensitive(choice, "M"))
{
    string operand = "*";
    int result = num1 * num2;
    printResult(num1, "*", num2, result);
}

else {
    Console.WriteLine("Invalid Option");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey(true);

void printResult(int num1, string operand, int num2, int result){
    Console.WriteLine($"The result is: {num1} {operand} {num2} = {result}");
}

bool EqualsCaseInsensitive(string left, string right) {
    return left.ToUpper() == right;
}