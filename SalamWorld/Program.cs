Console.WriteLine("Salam, World!");
Console.WriteLine();

Console.Write("What is your First Name: ");
string? firstName = Console.ReadLine();

Console.WriteLine("Please, Allow me to ask your Last Name. :) (y/n)");
string? allow = Console.ReadLine();

if(allow == "y")
{
    Console.Write("What is your Last Name: ");
    string? lastName = Console.ReadLine();
    Console.WriteLine("So, Your Full Name is {0} {1}.", firstName, lastName);
}
else
{
    Console.WriteLine("Your First Name is {0}.", firstName);
}

Console.ReadLine();
