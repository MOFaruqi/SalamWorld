Console.WriteLine("Salam, World!");
Console.WriteLine();

Console.WriteLine("Press 1: To see how to take user inpur.");
string? option = Console.ReadLine();

if (option == "1")
{
    Console.Write("What is your First Name: ");
    string? firstName = Console.ReadLine();

    Console.WriteLine("Please, Allow me to ask your Last Name. :) (y/n)");
    string? allow = Console.ReadLine();

    if (allow == "y")
    {
        Console.Write("What is your Last Name: ");
        string? lastName = Console.ReadLine();
        Console.WriteLine("So, Your Full Name is {0} {1}.", firstName, lastName);
    }
    else
    {
        Console.WriteLine("Your First Name is {0}.", firstName);
    }
}
else
{
    if(int.TryParse(option, out int value))
    {
        Console.WriteLine("Pressed option is not available.");
    }
    else
    {
        Console.WriteLine("Input is not an Integer, Please press any Number which is specified after PRESS Word, Thanks.");
    }
}

Console.ReadLine();
