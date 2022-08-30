/*Задача со звездочкой. Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994*/

int ConvertRomanToInt(char charStrRoman)
{
    int ArabNumber = 0;
    switch (charStrRoman)
    {
        case 'I': ArabNumber = 1; break;
        case 'V': ArabNumber = 5; break;
        case 'X': ArabNumber = 10; break;
        case 'L': ArabNumber = 50; break;
        case 'C': ArabNumber = 100; break;
        case 'D': ArabNumber = 500; break;
        case 'M': ArabNumber = 1000; break;
    }
    return ArabNumber;
}

int ParseRoman(string romanStr)
{
    int numArab = 0;
    int SumArabNumber = 0;
    for (int i = 0; i < romanStr.Length; i++)
    {
        numArab = ConvertRomanToInt(romanStr[i]);

        if ((i + 1) < romanStr.Length && numArab < ConvertRomanToInt(romanStr[i + 1]))
            SumArabNumber -= numArab;
        else
            SumArabNumber += numArab;
    }
    return SumArabNumber;
}

bool CheckOutRomanString(string romanStr)
{
    List<char> romanlist = new List<char>();

    romanlist.Add('I');
    romanlist.Add('V');
    romanlist.Add('X');
    romanlist.Add('L');
    romanlist.Add('C');
    romanlist.Add('D');
    romanlist.Add('M');

    for (int i = 0; i < romanStr.Length; i++)
    {
        if (!romanlist.Contains(romanStr[i]))
            return true;
    }
    return false;
}
//подумать, как проверить правильный порядок при вводе

Console.Write("Введите римское число: ");
string roman = Console.ReadLine();

if (CheckOutRomanString(roman))
    Console.WriteLine("Некорректные данные");
else
    Console.WriteLine(ParseRoman(roman));