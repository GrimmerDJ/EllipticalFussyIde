using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();

    Console.Write("Enter your date of birth (MM/DD/YYYY): ");
    string birthDate = Console.ReadLine();

    Console.Write("Enter your work phone number: ");
    string workPhone = Console.ReadLine();

    Console.Write("Enter your cell phone number: ");
    string cellPhone = Console.ReadLine();

    Console.WriteLine("\nPersonal Information:");
    Console.WriteLine("Name: " + name);
    Console.WriteLine("Date of birth: " + birthDate);
    Console.WriteLine("Work Phone: " + workPhone);
    Console.WriteLine("Cell Phone: " + cellPhone);
  }
}