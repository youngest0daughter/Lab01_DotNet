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


// Console.WriteLine("Добро пожаловать в анкету!");

// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine() ?? "";

// Console.Write("Введите вашу фамилию: ");
// string surname = Console.ReadLine() ?? "";

// Console.Write("Введите вашу группу: ");
// string group = Console.ReadLine() ?? "";

// Console.Write("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine() ?? "0");

// Console.Write("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine() ?? "0");

// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;

// string status = isExcellent ? "Отличник" : "Хорошист";

// Console.WriteLine("Ваша анкета");
// Console.WriteLine($"Имя:           {name} {surname}");
// Console.WriteLine($"Группа:        {group}");
// Console.WriteLine($"Возраст:       {age} лет");
// Console.WriteLine($"Средний балл:  {gpa}");
// Console.WriteLine($"Статус:        {status}");
// Console.WriteLine($"Лет до 30:     {30 - age}");

// Console.WriteLine("Нажмите Enter для выхода...");
// Console.ReadLine();

Console.WriteLine("Задание 1");
string l = "metro 2033";
int s = 7;
double p = 3.14159;
char abc = 'N';
Console.WriteLine($"Любимая игра: {l}");
Console.WriteLine($"Любимая цифра: {s}");
Console.WriteLine($"Число пи: {p}");
Console.WriteLine($"Любимая буква: {abc}\n");
Console.WriteLine();

Console.WriteLine("Задание 2");
Console.WriteLine("I");
Console.WriteLine("need");
Console.WriteLine("more");
Console.WriteLine("power!\n");
Console.WriteLine();

Console.WriteLine("Задание 3");
Console.WriteLine("\"Hello There\"\n");
Console.WriteLine();

Console.WriteLine("Задание 4");
int m = int.Parse(Console.ReadLine() ?? "0");
int pc = int.Parse(Console.ReadLine() ?? "0");
int keyboard = int.Parse(Console.ReadLine() ?? "0");
int mouse = int.Parse(Console.ReadLine() ?? "0");
int price = (m + pc + keyboard + mouse) * 3;
Console.WriteLine(price);
Console.WriteLine();

Console.WriteLine("Задание 5");
long a = long.Parse(Console.ReadLine() ?? "0");
long b = long.Parse(Console.ReadLine() ?? "0");
long result = 3 * (long)Math.Pow(a + b, 3) + 275 * (b * b) - 127 * a - 41;
Console.WriteLine(result);
Console.WriteLine();

Console.WriteLine("Задание 6");
double t = double.Parse(Console.ReadLine() ?? "0");
double fa = (t * 9 / 5) + 32;
Console.WriteLine($"Температура: {fa}°F");