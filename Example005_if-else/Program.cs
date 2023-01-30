Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "виталий")
{
    Console.WriteLine("Здарова чухан!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}