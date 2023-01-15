// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите Ваше имя");
string name = Console.ReadLine();
if (name.ToLower() == "деймон")
{    
    Console.WriteLine("Привет, сыночек мой любимый Деюшка!");
}
else
{
    Console.WriteLine($"Привет, {name}!");  
}