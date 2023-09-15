using muzychko_lesson4.Classes;
using muzychko_lesson4.Enums;
using System.Text.RegularExpressions;

Gender user1Gender;

//Створюємо нового юзера
User user1 = new User();

//Запит імені, прізвища та їхня перевірка на вміст заборонених символів
Console.WriteLine("Enter your First Name:");
user1.FirstName = Console.ReadLine();

while (!Regex.IsMatch(user1.FirstName, @"^[A-Za-z\s]+$"))
{
    Console.WriteLine("Name can`t contain numbers");
    user1.FirstName = Console.ReadLine();
}

Console.WriteLine("Enter your Last Name:");
user1.LastName = Console.ReadLine();

while (!Regex.IsMatch(user1.LastName, @"^[A-Za-z\s]+$"))
{
    Console.WriteLine("Last name can`t contain numbers");
    user1.LastName = Console.ReadLine();
}

//Запит введення гендеру (лише тих які знаходяться в enum)
while (true)
{
    Console.Write("Enter Gender (Male or Female):");
    string genderInput = Console.ReadLine();

    if (Enum.TryParse(genderInput, out user1Gender) && Enum.IsDefined(typeof(Gender), user1Gender))
    {
        break; // Вихід з циклу, якщо введене значення є допустимим
    }
    else
    {
        Console.WriteLine("Invalid input. Enter Gender again (Male or Female):");
    }
}
user1.Gender = user1Gender;

//Вивід override ToString(); з інформацією яку вніс користувач
Console.WriteLine(user1.ToString());
