Console.Write("Enter the username: ");
string username = Console.ReadLine(); // get data from terminal by this command 

if (username.ToLower == "dina") // "tolower" makes capital letters
{
    Console.WriteLine("Dina, what the hell are you doing here???");
}
else 
{
    Console.Write("Hey, ");
    Console.WriteLine(username);    
}