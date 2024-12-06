// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Transactions;
using Microsoft.VisualBasic;
var todos = new List<string>();
bool shallExit = false;
Console.WriteLine("Hello, World!");

while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    string userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "s":
        case "S":
            PrintTodos();
            break;
        case "a":
        case "A":
            AddTodo();
            break;
        case "r":
        case "R":
            RemoveTodo();
            break;
        case "e":
        case "E":
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
}


void PrintTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        System.Console.WriteLine($"{i + 1}: {todos[i]}");
    }

}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter a description:");
        description = Console.ReadLine();
    } while (!IsDescriptionValid(description));

    todos.Add(description);

}

bool IsDescriptionValid(string description)
{
    if (string.IsNullOrWhiteSpace(description))
    {
        Console.WriteLine("Description cannot be empty");
        return false;
    }
    else if (todos.Contains(description))
    {
        System.Console.WriteLine("Description cannot be a duplicate!");
        return false;
    }
    return true;
}

void RemoveTodo()
{
    if (!todos.Any())
    {
        ShowNoTodosMessage();
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the Index of the Todo to remove:");
        PrintTodos();
    } while (!TryReadIndex(out index));

    RemoveTodoAtIndex(index - 1);
   
  
}

void RemoveTodoAtIndex(int index)
{   var todo_to_be_removed = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine($"TODO Removed: {todo_to_be_removed}");
}

bool TryReadIndex(out int index)
    {

        var selected_index = Console.ReadLine();

        if (string.IsNullOrEmpty(selected_index))
        {
            index = 0;
            Console.WriteLine("Index cannot be empty!");
            return false;
        }
        else if (!int.TryParse(selected_index, out index) || index < 1 || index > todos.Count())
        {
            Console.WriteLine("The given index is not valid.");
            return false;
        }
        else
        {

            return true;
        }
    }

static void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet");
}