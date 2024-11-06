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
    if (todos.Count == 0) {
        Console.WriteLine("No todos have been added yet");
    }
    else
    {
        for (int i=0; i < todos.Count; i++)
        {
            System.Console.WriteLine($"{i+1}: {todos[i]}");
        }
    }
}

void AddTodo()
{
    bool isValid = false;
    while (!isValid)
    {
        Console.WriteLine("Enter a description:");
        var description = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("Description cannot be empty");
        }
        else if (todos.Contains(description))
        {
            System.Console.WriteLine("Description cannot be a duplicate!");
        }
        else
        {
            todos.Add(description);
            isValid = true;
        }
    }

}

void RemoveTodo() {
   if (!todos.Any()) 
   {
        Console.WriteLine("No TODOs have been added yet");
   }
   else
   {
        bool isValid = false;
        while(!isValid)
        {
            PrintTodos();
            Console.WriteLine("Select the Index of the Todo to remove:");
            var selected_index = Console.ReadLine();

            if (string.IsNullOrEmpty(selected_index))
            {
                Console.WriteLine("Index cannot be empty!");
            }
            else if (!int.TryParse(selected_index, out int index) || index < 1 || index > todos.Count())
            {
                Console.WriteLine("The given index is not valid.");
            }
            else
            {
                var removed_item = todos[index-1];
                todos.Remove(removed_item);
                Console.WriteLine($"TODO Removed: {removed_item}");
                isValid = true;
            }
        }
   }
}