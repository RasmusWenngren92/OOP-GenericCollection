namespace OOP___Generic_Collection;



public class Employee //Creating a new class
     (int id, string name, string lastName, string gender, int salary, int age)//Primary Constructor
{    //Read-only properties
     public int? EmployeeId { get; } = id;
     public string? Name { get; } = name;
     public string? LastName { get; } = lastName;
     public string? Gender { get; } = gender;
     public int Salary { get; } = salary;
     public int Age { get; } = age;

     // Constructor to initialize all properties of an Employee object

     // Override the ToString() method to provide a formatted string representation of the Employee object
     public override string ToString()
     {
          return  $"\n\tEmployeeId  : {EmployeeId}" +
                  $"\n\tLast Name   : {LastName} " +
                  $"\n\tFirst name  : {Name}" +
                  $"\n\tEmployee Age: {Age} " +
                  $"\n\tGender      : {Gender} " +
                  $"\n\tSalary      : {Salary}";
     }
    
}

