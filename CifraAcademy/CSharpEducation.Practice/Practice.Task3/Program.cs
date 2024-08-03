using static System.Console;

double lengthValue;
bool result;
double[] numbers = new double[3];
WriteLine("Input a, b, f");

for (int i = 0; i < 3; i++)
{
    result = false;
    while (result != true)
    {
        // WriteLine("Введиде температуру в градусах Цельсия:");

        string? input = ReadLine();

        result = double.TryParse(input, out lengthValue);

        if (result == true)
        {
            numbers[i] = lengthValue;
            WriteLine($"Величина = {lengthValue}");
        }
    }
}
if ((numbers != null) & (numbers[0] != 0))
    WriteLine($"(a+b-f/a)+f*a*a-(a+b) = {(numbers[0] * numbers[0] - 1 / numbers[0]) * numbers[2]}");
else WriteLine("Уравнение не имеет решения(на ноль делить нельзя)");
