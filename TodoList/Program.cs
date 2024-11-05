var words = new List<string>{
    "one",
    "two",
};

Console.WriteLine("Count of elements is " + words.Count);

foreach (var word in words)
{
    Console.WriteLine(word);
}








Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOS");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");
string userChoice = Console.ReadLine();

switch(userChoice)
{
    case "s":
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "a":    
    case "A":
        PrintSelectedOption("Add a Todo");
        break;
    case "r":
    case "R":
        PrintSelectedOption("Remove A Todo");
        break;
    case "e":
    case "E":
        PrintSelectedOption("Exit the program");
        break;
    default:
        Console.WriteLine("Invalid Choice");
        break;
}

void PrintSelectedOption(string option) {
    Console.WriteLine(option);
}

Console.ReadKey();