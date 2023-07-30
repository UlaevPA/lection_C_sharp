Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "павел")
{
    Console.WriteLine("Ура, это же Павел!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}