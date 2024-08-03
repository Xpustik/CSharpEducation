using static System.Console;



int inCheck()
{
    bool result = false;
    int lengthValue;
    //int counter = 0;

    while (result != true)
    {
        //   WriteLine("Введиде температуру в градусах Цельсия:");

        string? input = ReadLine();

        result = int.TryParse(input, out lengthValue);

        if (result) return lengthValue;
        // if (counter > 5) return -1;
        //counter++;
    }
    return -1;
}

WriteLine("Введите кол-во *");
int valueStar;

valueStar = inCheck();

for (int i = 0; i < valueStar; i++)
{
    for (int j = 0; j < valueStar - i; j++) Write(" ");
    for (int k = 0; k < i + 1; k++) Write($"*");
    WriteLine();
}

for (int i = 0; i < valueStar; i++)
{
    //for (int j = 0; j < valueStar - i; j++) Write(" ");
    for (int k = 0; k < i + 1; k++) Write("*");
    WriteLine();
}

WriteLine("Введите символ");
var simbol = ReadKey();
//WriteLine(simbol.Key);
//WriteLine(simbol.KeyChar);


for (int i = 0; i < valueStar; i++)
{
    for (int j = 0; j < valueStar - i; j++) Write(" ");
    for (int k = 0; k < i + 1; k++) Write(simbol.KeyChar);
    WriteLine();
}

for (int i = 0; i < valueStar; i++)
{
    //for (int j = 0; j < valueStar - i; j++) Write(" ");
    for (int k = 0; k < i + 1; k++) Write(simbol.KeyChar);
    WriteLine();
}

