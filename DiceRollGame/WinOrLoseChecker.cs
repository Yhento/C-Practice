// See https://aka.ms/new-console-template for more information
class WinOrLoseChecker
{
  private ChanceContainer _chances = new ChanceContainer();


  public bool CheckWinner(int user_input, int winning_number)
  {
    if (user_input == winning_number)
    {
      Console.WriteLine("You Win!");
      return true;
    }
    else
    {
      _chances.Chance--;

      Console.WriteLine(_chances.Chance > 0 ? $"Wrong Number: You have {_chances.Chance} chances remaining." : "You Lose.");

      return _chances.Chance > 0 ? false : true;
    }
  }

}
