using System;

class Machine
{
    private string machineID;  // Stores the Machine ID
    private string description; // Stores the description of the machine

    // Constructor to extract machineID and description from a given string
    public Machine(string input)
    {
        // Check if input is null or empty
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Input cannot be empty.");
        }

        // Splitting the input using ':' to separate Machine ID and description
        string[] parts = input.Split(':');

        // Checking if the input contains both Machine ID and Description
        if (parts.Length == 2)
        {
            machineID = parts[0].Trim();  // Remove extra spaces from Machine ID
            description = parts[1].Trim(); // Remove extra spaces from Description
        }
        else
        {
            throw new ArgumentException("Invalid input format. Please use 'ID: Description' format.");
        }
    }

    // Method to check if the description contains a given word
    public bool ContainsWord(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return false;
        }

        // Convert both the description and the word to lowercase for case-insensitive comparison
        return description.ToLower().Contains(word.ToLower());
    }

    // Method to display machine details
    public void DisplayInfo()
    {
        Console.WriteLine("Machine ID: " + machineID);
        Console.WriteLine("Description: " + description);
    }
}

// Main program to test the Machine class
class Program
{
    static void Main()
    {
        try
        {
            // Creating a Machine object with example input
            Machine machine = new Machine("M123: High-speed drilling machine");

            // Displaying the extracted Machine ID and Description
            machine.DisplayInfo();

            // Checking if the description contains certain words
            Console.WriteLine("Contains 'drilling'?: " + machine.ContainsWord("drilling")); // True
            Console.WriteLine("Contains 'cutting'?: " + machine.ContainsWord("cutting"));   // False
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
