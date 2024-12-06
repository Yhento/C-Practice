using System.Runtime.CompilerServices;


// var rectangle1 = new Rectangle(5, 10);

// Console.WriteLine(rectangle1.Description);

// Console.WriteLine(DateTime.Now);
// Console.WriteLine($"{DateTime.Now.Day} {DateTime.Now.Month} {DateTime.Now.Year}");


// Console.ReadKey();


// class MedicalAppointmentPrinter
// {
//     public void Print(MedicalAppointment medicalAppointment)
//     {
//         Console.WriteLine(
//             $"Appointment will begin on {medicalAppointment.GetAppointmentDate}"
//         );
//     }
// }


// class MedicalAppointment
// {
//     private string _patientName;
//     private DateTime _date;

//     public MedicalAppointment(string patientName, DateTime date)
//     {
//         _patientName = patientName;
//         _date = date;
//     }

//     public DateTime GetAppointmentDate => this._date;


//     public MedicalAppointment(string patientName, int daysFromNow = 7)
//     {
//         _patientName = patientName;
//         _date = DateTime.Now.AddDays(daysFromNow);
//     }

//     public void Reschedule(DateTime date)
//     {
//         _date = date;
//         var appointmentPrinter = new MedicalAppointmentPrinter();
//         appointmentPrinter.Print(this);
//     }

//     public void OverwriteMonthAndDay(int month, int day)
//     {
//         _date = new DateTime(_date.Year, month, day);

//     }

//     public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//     {
//         _date = new DateTime(
//             _date.Year,
//             _date.Month + monthsToAdd,
//             _date.Day + daysToAdd);
//     }
// }



var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

System.Console.WriteLine("Count of Rectangle objects is " + Rectangle.CountOfInstances);

int result = rectangle1.WidthTimesNumberOfSides();
string result2 = NumberToDayOfWeekTranslator.Translate(8);

string transformedWords = StringsTransformator.TransformSeparators("this,is,some,string", ",", "+");

Console.ReadKey();
public static class StringsTransformator
{
  public static string TransformSeparators(
      string input,
      string originalSeparator,
      string targetSeparator)
  {
    string[] separatedWords = input.Split(originalSeparator);
    string result = string.Join(targetSeparator, separatedWords);
    return result;
  }
}

public static class NumberToDayOfWeekTranslator
{
  public static string Translate(int number)
  {
    switch (number)
    {
      case 1:
        return "Monday";

      case 2:
        return "Tuesday";

      case 3:
        return "Wednesday";

      case 4:
        return "Thursday";

      case 5:
        return "Friday";

      case 6:
        return "Saturday";

      case 7:
        return "Sunday";

      default:
        return "Invalid day of the week";
    }
  }
}



static class Calculator
{
  public static int Add(int a, int b) => a + b;
  public static int Subtract(int a, int b) => a - b;
  public static int Multiply(int a, int b) => a * b;
}


class Rectangle
{
  public static int CountOfInstances { get; private set; }

  private static DateTime _firstUsed = DateTime.Now;

  static Rectangle()
  {
    _firstUsed = DateTime.Now;
  }
  private int _height;



  public Rectangle(int width, int height)
  {

    Width = GetLengthOrDefault(width, nameof(Width));

    _height = GetLengthOrDefault(height, nameof(_height));

    ++CountOfInstances;


  }

  public int Width { get; private set; }

  public int GetHeight() => _height;

  public void SetHeight(int value)
  {
    if (value > 0)
    {
      _height = value;
    }
  }

  private int GetLengthOrDefault(int length, string name)
  {
    const int DefaultValueIfNonPositive = 1;
    if (length <= 0)
    {
      Console.WriteLine($"{name} must be a positive number.");
      return DefaultValueIfNonPositive;
    }

    return length;

  }

  public int CalculateCircumference() => 2 * Width + 2 * _height;

  public int CalculateArea() => Width * _height;

  public int WidthTimesNumberOfSides() => Width * NumberOfSides;

  public string Description => $"A rectangle with width {Width} and height {_height}";

  public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";

  public string NotUsingAnyState() => "abc";

  public const int NumberOfSides = 4;


}





// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TODOS");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");
// string userChoice = Console.ReadLine();

// switch(userChoice)
// {
//     case "s":
//     case "S":
//         PrintSelectedOption("See all TODOs");
//         break;
//     case "a":    
//     case "A":
//         PrintSelectedOption("Add a Todo");
//         break;
//     case "r":
//     case "R":
//         PrintSelectedOption("Remove A Todo");
//         break;
//     case "e":
//     case "E":
//         PrintSelectedOption("Exit the program");
//         break;
//     default:
//         Console.WriteLine("Invalid Choice");
//         break;
// }

// void PrintSelectedOption(string option) {
//     Console.WriteLine(option);
// }

