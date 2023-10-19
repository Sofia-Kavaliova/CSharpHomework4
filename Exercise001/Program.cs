// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int PowNumber(int a, int b)
{
    int res=1;
    for(int i=0; i<b; i++)
    {
        res*=a;
    }
    return res;
}
//------------------
int numberA = ReadInt("Введите первое число: ");
int numberB = ReadInt("Введите второе число: ");
Console.WriteLine(PowNumber(numberA, numberB));