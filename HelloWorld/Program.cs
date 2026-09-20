string firstName = "Павел";
string lastName = "Алтухов";
string group = "ИСП-241";
int birthYear = 2008;
double gpa = 5.0;
bool hasScholarship = true;

int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine() ?? "";
Console.WriteLine($"Отлично! {firstName} любит {subject}.");