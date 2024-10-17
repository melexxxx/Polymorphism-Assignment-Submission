// Program.cs
using System;

// Employee class inheriting from Person and implementing IQuittable
public class Employee : Person, IQuittable
{
    // Implement the abstract method SayName from the Person class
    public override void SayName()
    {
        // Prints the employee's full name
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        // Prints a message indicating the employee is quitting
        Console.WriteLine(firstName + " " + lastName + " has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and set the first and last name
        Employee emp = new Employee() { firstName = "Sample", lastName = "Student" };

        // Call the SayName method to print the employee's full name
        emp.SayName();

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmp = emp;

        // Call the Quit method on the IQuittable object
        quittableEmp.Quit();

        // Keep the console open until a key is pressed
        Console.ReadLine();
    }
}
