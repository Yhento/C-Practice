// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

List<string> valid_inputs = new List<string> { "S", "A", "R", "E" };
List<string> Todos = new List<string>();
bool isValidInput;
string userInput;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("What would you like to do?");
    PrintOptions();


    do
    {
        userInput = Console.ReadLine().ToUpper();

        isValidInput = valid_inputs.Contains(userInput);

        if (!isValidInput)
        {
            Console.WriteLine("Incorrect Input!");
            PrintOptions();
        }

    } while (!isValidInput);

    switch (userInput)
    {
        case "S":
            if (!Todos.Any())
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                printTodos(Todos);
            }
            break;

        case "A":
            bool todoIsDuplicate;
            bool todoIsEmpty;
            do
            {
                Console.WriteLine("Enter the TODO description: ");
                string todo_to_add = Console.ReadLine();
                todoIsDuplicate = IsTodoDuplicate(todo_to_add);
                todoIsEmpty = IsEmpty(todo_to_add);
                if (todoIsEmpty)
                {
                    System.Console.WriteLine("The description cannot be empty");
                }
                else if (todoIsDuplicate)
                {
                    System.Console.WriteLine("The description must be unique");
                }
                else
                {
                    AddTodo(todo_to_add);
                }
            } while (todoIsDuplicate || todoIsEmpty);
            break;
        case "R":
            bool IndexIsNumber;
            bool IndexIsEmpty;
            bool IndexIsValid;
            string removed_item;
         
            if (!Todos.Any())
            {
                Console.WriteLine("No TODOs have been added yet.");
                break;
            }

            do
            {
                System.Console.WriteLine("Select the index of the Todo you want to remove:");
                printTodos(Todos);
                string index_to_remove = Console.ReadLine();
                IndexIsEmpty = IsEmpty(index_to_remove);
                IndexIsNumber = int.TryParse(index_to_remove, out int index);
                
                if (IndexIsEmpty){
                    System.Console.WriteLine("Selected Index Cannot Be Empty.5");
                    IndexIsValid = false;
                }
                else if (!IndexIsNumber || !IsIndexInList(Todos, index - 1))
                {
                    System.Console.WriteLine("The given index is not valid");
                    IndexIsValid = false;
                }
                else
                {
                    IndexIsValid = true;
                    removed_item = Todos[index-1];
                    RemoveTodo(Todos,index-1);
                    System.Console.WriteLine($"TODO Removed: {removed_item}");
                }


            } while (!IndexIsValid);
            break;
    }



} while (userInput.ToUpper() != "E");


void PrintOptions()
{
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void printTodos(List<string> Todos)
{
    for (int i = 0; i < Todos.Count(); i++)
    {
        Console.WriteLine($"{i + 1}. {Todos[i]}");
    }
}

void AddTodo(string userInput)
{
    Todos.Add(userInput);
    System.Console.WriteLine($"TODO successfully added: {userInput}");
}

void RemoveTodo(List<string> Todos, int index)
{
    Todos.RemoveAt(index);
}

bool IsTodoDuplicate(string todo)
{
    if (Todos.Contains(todo))
    {
        return true;
    }
    return false;
}

bool IsEmpty(string userInput)
{
    if (string.IsNullOrWhiteSpace(userInput))
    {
        return true;
    }
    return false;
}

bool IsIndexInList(List<string> todos, int index)
{
    if (todos != null && index >= 0 && index < todos.Count)
    {
        return true;
    }
    else
    {
        return false;
    }
}
