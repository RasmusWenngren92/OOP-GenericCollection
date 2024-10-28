
namespace OOP___Generic_Collection;

class Program
{
    static void Main(string[] args)
    {

        string separator = "---------------------------------------";
        List<Employee> employees =
        [
            new Employee(001, "John", "Wick", "Male", 25000, 20),
            new Employee(002, "Nora", "Jones", "Female", 32055, 35),
            new Employee(003, "Frodo", "Baggins", "Male", 25000, 20),
            new Employee(004, "Peregrin", "Took", "Male", 25000, 20),
            new Employee(005, "Arwen", "Undómiel", "Female", 25000, 20)

        ];//Creating List

        Stack<Employee> employeesStack = new Stack<Employee>(employees);//Creating stack with List of employees
        foreach (var item in employeesStack.ToList())//Looping through all the Employees
        {
            Console.WriteLine( $"\n\tEmployeeId  : {item.EmployeeId}" +
                               $"\n\tLast Name   : {item.LastName} " +
                               $"\n\tFirst name  : {item.Name}" +
                               $"\n\tEmployee Age: {item.Age} " +
                               $"\n\tGender      : {item.Gender} " +
                               $"\n\tSalary      : {item.Salary}");
            Console.WriteLine(employeesStack.Count);// keeping count of objects in the stack
        }
        Console.WriteLine(separator);
        Stack<Employee> employeesStack2 = new Stack<Employee>();
        foreach (var item in employeesStack.ToList())//Looping through all the Employees
        {
            Console.WriteLine( $"\n\tEmployeeId  : {item.EmployeeId}" +
                               $"\n\tLast Name   : {item.LastName} " +
                               $"\n\tFirst name  : {item.Name}" +
                               $"\n\tEmployee Age: {item.Age} " +
                               $"\n\tGender      : {item.Gender} " +
                               $"\n\tSalary      : {item.Salary}");
            employeesStack2.Push(employeesStack.Pop());// popping and pushing the employees to another stack
            Console.WriteLine(employeesStack.Count);// keeping count of objects in the stack
        }
        Console.WriteLine(separator);

        for (var i = 0; i < 2; i++)// for loop to peek at two elements in the stack
        {
            var currentPeek = employeesStack2.Peek();
            Console.WriteLine($"Retrieving Using Peek Element: {currentPeek}");
            Console.WriteLine($"Objects left in stack: {employeesStack2.Count}");
            Console.WriteLine();
        }

        Console.WriteLine(separator);
        //Defines EmployeeIdd to search for in the Stack
        var searchForEmployeeId = 3;
        
        //Using the Any() method to iterate through the stack, using a lambda expression
        bool isInStack = employeesStack2.Any(employee => employee.EmployeeId == searchForEmployeeId);
        
        //If bool isInStack returns true it will print out that the Employee exist
        //Otherwise it will return that the Employee does not exist in the stack
        Console.WriteLine(isInStack
            ? $"Employee {searchForEmployeeId} is in the stack"
            : $"Employee {searchForEmployeeId} is not in the stack");
        
        
        Console.WriteLine(separator);
        //Defines EmployeeId to search for
        int searachEmployeeId = 2;
        
        //Using LINQ and Contains to compare if any Employee has the specifik EmployeeId, using a lambda expression
        bool exist = employees.Select(emp => emp.EmployeeId).Contains(searachEmployeeId);
        
        //If bool exist returns true it will print out that the Employee exist
        //Otherwise it will return that the Employee does not exist in the list 
        Console.WriteLine(exist
        ? "Employee2 object exists in the list"
        : "Employee2 object does not exist in the list");
        
        Console.WriteLine(separator);
        
        //Defines Gender to search for using a lambda expression
        Employee? genderFind = employees.Find((item) => item.Gender == "Male");
        Console.WriteLine(genderFind);
        
        //List for going through all genders with a foreach loop using a lambda expression
        List<Employee> findGender = employees.FindAll(item => item.Gender == "Male");
        foreach (var employee in findGender)
        {
            //Prints all employee that matches the requirement
            Console.WriteLine(employee);
        }
        
        Console.WriteLine(separator);
        
    }
    
}