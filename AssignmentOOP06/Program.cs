#region Qusetion01:
// Q1: What is abstraction in OOP?
//     How is it different from encapsulation?
//     Give a real-world example (not from the session) that shows the difference between the two.

// Answer: Abstraction is the concept of showing only the essential features of an object while hiding the complex implementation details.
//         It focuses on what an object does, not how it does it.
//         Encapsulation, on the other hand, is the concept of bundling data and methods that operate on that data within a single unit (class) and restricting access to some of the object's components.
//         It focuses on how an object is implemented and protects the internal state of the object from outside interference.
/*
          Real-World Example (ATM Machine)
         
          * Abstraction:
          When you use an ATM machine, you only see options like:
         - Withdraw money
         - Check balance
         - Deposit money
          You don’t see how the bank processes the transaction internally.
          The complex system is hidden. This is abstraction.
          
          * Encapsulation
          Inside the bank system, your account balance is stored privately.
          You cannot directly change it. Instead, you must use operations like:
          - Withdraw
          - Deposit
          These operations control how the balance changes.
          This is encapsulation.
 */

#endregion

#region Qusetion02:
// Q2: What is the difference between an abstract class and an interface? Give at least four differences. When would you choose one over the other?

// Answer: An abstract class cannot be instantiated and can contain both abstract and concrete methods, allowing code reuse.
//         An interface, acting as a strict contract, primarily defines abstract method signatures that implementing classes must define, supporting multiple inheritance.
//         An abstract class can have fields and constructors, while an interface cannot have fields and only allows for default implementations in C# 8.0 and later.
//
//       An abstract class is used when there is a clear hierarchical relationship and shared code among classes,
//         while an interface is ideal for defining capabilities that can be implemented by unrelated classes.
#endregion

#region Qusetiom03:
/*  Q3 : Look at the following code and answer the questions below:

public abstract class Appliance
{
    public string Brand { get; set; }

    protected Appliance(string brand) { Brand = brand; }

    public abstract double PowerConsumption();

    public virtual string Status() => "Standby";

    public string Label() => $"{Brand} - {PowerConsumption()}W";
}

public class WashingMachine : Appliance
{
    public WashingMachine(string brand) : base(brand) { }
    public override double PowerConsumption() => 500;
    public override string Status() => "Washing";
}

public class Toaster : Appliance
{
    public Toaster(string brand) : base(brand) { }
    public override double PowerConsumption() => 800;
}*/

// a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?

// Asnwer: No, you cannot instantiate an abstract class directly.
//         Abstract classes are meant to be inherited by other classes and cannot be instantiated on their own.
//         They serve as a blueprint for other classes to implement the abstract methods defined within them.


// b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?

// Answer: PowerConsumption() is an abstract method, meaning that it must be implemented by any non-abstract class that inherits from Appliance. It defines a contract for calculating power consumption, but the specific implementation is left to the subclasses.
//         Status() is a virtual method, which provides a default implementation ("Standby") that can be overridden by subclasses if they need to provide a different status. This allows for flexibility while still providing a common behavior.
//        Label() is a concrete method, which means it has a complete implementation and cannot be overridden. It uses the Brand property and the PowerConsumption() method to generate a label for the appliance.
//        The designer likely made this method concrete because it provides a common functionality that all appliances can use without needing to change it.


// c) If you call Status() on a Toaster object, what will it return? Why?

// Answer: If you call Status() on a Toaster object, it will return "Standby".
//         This is because the Toaster class does not override the Status() method, so it uses the default implementation provided by the Appliance class, which returns "Standby".
#endregion

#region Qusetion04:
/* Q4: Look at the following code and answer the questions below:

// File: Calculator.cs
public partial class Calculator
{
    public double LastResult { get; private set; }
    partial void OnCalculated(double result);

    public double Add(double a, double b)
    {
        LastResult = a + b;
        OnCalculated(LastResult);
        return LastResult;
    }
}

// File: Calculator.Logging.cs
public partial class Calculator
{
    partial void OnCalculated(double result)
    {
        Console.WriteLine($"Log: result = {result}");
    }
}

// File: DoubleExtensions.cs
public static class DoubleExtensions
{
    public static string ToCurrency(this double value)
        => $"${value:F2}";
}*/

// a) What is a partial class? Why would a developer split Calculator into two files?

//Answer: A partial class is a class that can be split across multiple files.
//        Each part of the class must be marked with the 'partial' keyword, and when compiled, all parts are combined into a single class.
//        A developer might split the Calculator class into two files to separate concerns and improve code organization.
//        For example, one file (Calculator.cs) contains the core functionality of the calculator, while another file (Calculator.Logging.cs) contains logging-related code.


// b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?

// Answer: A partial method is a method that is declared in one part of a partial class and can be implemented in another part.
//         If the implementation is not provided, the method call is removed at compile time, and the code will still compile without any errors.
//         In this case, if the OnCalculated() implementation in Calculator.Logging.cs is deleted, the code will still compile because the call to OnCalculated() will simply be ignored, and there will be no runtime error.


// c) What is an extension method? What are the three rules for writing one?

// Answer: An extension method is a static method that allows you to add new methods to existing types without modifying the original type or creating a new derived type.
//          The three rules for writing an extension method are:
//          1. The method must be defined in a static class.
//          2. The method itself must be static.
//          3. The first parameter of the method must specify the type it extends, and it must be preceded by the 'this' keyword.


// d) What will the following code print?
/* Calculator calc = new Calculator();
double result = calc.Add(19.5, 0.5);
Console.WriteLine(result.ToCurrency());*/

// Answer: The code will print: Log:   result = 20
//                                     $20.00
#endregion

#region part02: Ticket Booking System

using AssignmentOOP06.Models;
using AssignmentOOP06.Helpers;

class progam
{
    static void Main()
    {
        Cinema cinema = new Cinema("Roxy Cinema");

        cinema.OpenCinema();

       // Ticket t = new Ticket("Test", 100);      // error: Cannot create instance of abstract type 'Ticket'

        StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
        VIPTicket t2 = new VIPTicket("Avengers", 200, true);
        IMAXTicket t3 = new IMAXTicket("Dune", 100, true);

        t1.Book();
        t2.Book();
        t3.Book();

        cinema.AddTicket(t1);
        cinema.AddTicket(t2);
        cinema.AddTicket(t3);

        cinema.PrintAllTickets();

        Console.WriteLine("\n======= Polymorphism: Final Price per Ticket ======");

        Ticket[] arr = { t1, t2, t3 };

        foreach (Ticket t in arr)
        {
            Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
        }

        Console.WriteLine("\n====== Extension Method: Receipt =======");

        Console.WriteLine(t2.GenerateReceipt());

        Console.WriteLine("\n====== Extension Method: Total Revenue =======");

        Console.WriteLine($"Total Revenue: {arr.TotalRevenue():F2}");

        cinema.CloseCinema();

        Console.ReadKey();
    }
}
#endregion