using static System.Console;
using System.Globalization;

WriteLine("Введите строку");

string strValue = string.Empty;
string str = ReadLine();
WriteLine(str.ToUpper());
WriteLine(str.ToLower());

TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

WriteLine(ti.ToTitleCase(str));

/*
string str2=str.ToLower();
WriteLine(str2 + " " + str);
str2 = str2.ToUpper();

foreach (var item in str)
{
    if (char.IsLower(item))
        strValue += char.ToUpper(item);
   
}
WriteLine(str.ToLowerra
WriteLine(strValue);
strValue = string.Empty;

foreach (var item in str)
{
    if (char.IsUpper(item))
        strValue += char.ToLower(item);

}

WriteLine(strValue);
*/