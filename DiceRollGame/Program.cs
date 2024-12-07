// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Microsoft.VisualBasic;

int winning_number = new Random().Next(1, 6);
string user_input = "";

var winOrLoseChecker = new WinOrLoseChecker();
Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries");
do
{
  Console.WriteLine("Enter a number:");
  user_input = Console.ReadLine();
} while (!ValidNumberChecker.IsValidNumber(user_input) || !winOrLoseChecker.CheckWinner(StringToNumberConverter.StringToNumber(user_input), winning_number));
Console.ReadKey();
