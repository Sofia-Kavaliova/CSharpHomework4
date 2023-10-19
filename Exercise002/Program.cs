// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadIntAbs(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
int LenNumber(int value)
{
    int res=0;
    while (value>0)
    {
        res +=value%10;
        value=value/10;
    }
    return res;
}
//---------------
int number = ReadIntAbs("Введите число: ");
Console.WriteLine(LenNumber(number));