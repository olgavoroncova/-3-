// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


/*Console.WriteLine("Введите пятизначное число: "); 
int number = Convert.ToInt32(Console.ReadLine());
int numberLen = (int)Math.Log10(number);
int first = numberLen;
int last = 1;
int firstDigit = (int)(number / Math.Pow(10, numberLen));
int lastDigit = (number / last) % 10;

if (numberLen == 4) //Если убрать проверку этого условия, то решение будет доступно для чисел от 1 до 2,147,483,647 :)
{
    for (int i = 1; i <= ((numberLen + 1) / 2); i++)
    {
        if (firstDigit == lastDigit)
        {
            first = first - 1;
            last = last * 10;
            firstDigit = (int)(number / Math.Pow(10, first) % 10);
            lastDigit = (number / last) % 10;
        }
    }
    if (firstDigit == lastDigit)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Значение неверно! Введите пятизначное число!");
}
*/
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

/*Console.WriteLine("Введите координаты точки A по x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по z");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по y");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по z");
double zB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine($"расстояние между ними в 3D пространстве {res:f2}");
*/


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine(result);
}