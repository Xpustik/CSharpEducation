using static System.Console;

double lengthValue;
bool result = false;
while (result != true)
{
    WriteLine("Введиде длину в километрах:");

    string? input = ReadLine();

    result = double.TryParse(input, out lengthValue);

    if (result == true) WriteLine($"Величина в сантиметрах = {lengthValue * 100000}");
}

WriteLine();

result = false;
while (result != true)
{
    WriteLine("Введиде температуру в градусах Цельсия:");

    string? input = ReadLine();

    result = double.TryParse(input, out lengthValue);

    if (result == true) WriteLine($"Величина в градусах Фаринтейта = {(lengthValue * 9 / 5 + 32)}");
}

WriteLine();

result = false;
while (result != true)
{
    WriteLine("Введиде температуру в градусах Цельсия:");

    string? input = ReadLine();

    result = double.TryParse(input, out lengthValue);

    if (result == true) WriteLine($"Величина в градусах Фаринтейта = {(lengthValue * 9 / 5 + 32)}");
}


// Task 3
/*

*/