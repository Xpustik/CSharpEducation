// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int age;
string name;
string company;
bool logic;
double mass;

int ageMan = 30;
string nameMan = "Василий";
int tempreture = 18;
bool maleOrFemale = true;

Console.WriteLine("Введите Ваше имя");
name = Console.ReadLine();
Console.WriteLine($"Привет {name}!");
Console.WriteLine();

Console.WriteLine("Введите первую фразу:");
string text1= Console.ReadLine();
Console.WriteLine("Введите вторую фразу:");
string text2= Console.ReadLine();
Console.WriteLine();
Console.WriteLine(text1 + " " + text2);
Console.WriteLine();

const double numberPi = 3.14;
double radius = 6;

double squere=numberPi*radius*radius;
Console.WriteLine($"Площадь круга радиусом {radius} равна {squere}");
Console.WriteLine();

double catheterA = 15.0, catetherB = 19.0, girpotenuseC = 25;
Console.WriteLine($"Гипотенуза равна {Math.Sqrt(catheterA * catheterA + catetherB + catetherB)}");
Console.WriteLine();
Console.WriteLine($"Катет равен {Math.Sqrt(girpotenuseC*girpotenuseC-catheterA*catheterA)}");