Console.WriteLine("Add username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey, this is MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}