// See https://aka.ms/new-console-template for more information
public static class ValidNumberChecker
{
  public static bool IsValidNumber(string user_input)
  {
    int input;
    if (int.TryParse(user_input, out input))
    {
      return true;
    }
    else
    {
      System.Console.WriteLine("Incorrect Input.");
      return false;
    }
  }

}
