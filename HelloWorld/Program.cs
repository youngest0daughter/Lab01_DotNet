// string firstName = "Павел";
// string lastName = "Алтухов";
// string group = "ИСП-241";
// int birthYear = 2008;
// double gpa = 5.0;
// bool hasScholarship = true;

// int currentYear = 2026;
// int age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine() ?? "";
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");

// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine() ?? "0");

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");

// if (num2 != 0)
//     Console.WriteLine($"Частное: {num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль невозможно!");


Console.WriteLine("Добро пожаловать в анкету!");

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine() ?? "";

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine() ?? "";

Console.Write("Введите вашу группу: ");
string group = Console.ReadLine() ?? "";

Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine() ?? "0");

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status = isExcellent ? "Отличник" : "Хорошист";

Console.WriteLine("Ваша анкета");
Console.WriteLine($"Имя:           {name} {surname}");
Console.WriteLine($"Группа:        {group}");
Console.WriteLine($"Возраст:       {age} лет");
Console.WriteLine($"Средний балл:  {gpa}");
Console.WriteLine($"Статус:        {status}");
Console.WriteLine($"Лет до 30:     {30 - age}");

Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();