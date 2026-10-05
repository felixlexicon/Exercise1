using Övning1;

Console.WriteLine("Hello, Michael!");

EmployeeRegister register = new EmployeeRegister();


void InteractiveConsole()
{
    while (true)
    {
        Console.WriteLine("Enter new employee name to begin add, 'exit' to quit, or 'list' to view employees:");
        string name = Console.ReadLine();
        while (name.Length == 0)
        {
            Console.WriteLine("Input cannot be empty. Please enter new name, 'exit' or 'list':");
            name = Console.ReadLine();
        }
        if (name.ToLower() == "exit")
            break;
        else if (name.ToLower() == "list")
        {
            register.ListEmployees();
            continue;
        }
        Console.WriteLine("Enter employee salary:");
        if (!uint.TryParse(Console.ReadLine(), out uint salary))
        {
            Console.WriteLine("Invalid salary input. Addition aborted.");
            continue;
        }
        Employee newEmployee = new Employee(name, salary);
        register.AddEmployee(newEmployee);
        Console.WriteLine($"Added: {newEmployee}");
    }
}

InteractiveConsole();