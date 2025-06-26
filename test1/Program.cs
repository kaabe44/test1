using System;

class Program
{
    static void Main()
    {
        // Declare variables
        string name = "Abdulahi mohamed husein";
        string motherName = "maryan maxamed";
        DateTime dob = new DateTime(2003, 5, 12); // Format: YYYY, MM, DD
        string pob = "bookh";
        string email = "kaabacadde18@gmail.com";
        char sex = 'M'; // 'M' for Male, 'F' for Female
        string telephone = "+252907865222";
        string status = "Single"; // Can be "Single", "Married", etc.

        // Output the variables
        Console.WriteLine("Personal Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Mother's Name: {motherName}");
        Console.WriteLine($"Date of Birth: {dob.ToShortDateString()}");
        Console.WriteLine($"Place of Birth: {pob}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Sex: {sex}");
        Console.WriteLine($"Telephone: {telephone}");
        Console.WriteLine($"Status: {status}");
    }
}