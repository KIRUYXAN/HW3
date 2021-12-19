//а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел.
//Сами числа и сумму вывести на экран, используя tryParse.

int sum = 0;
int a;
string text = "";
string b;
bool flag;

do
{
    do
    {
        Console.WriteLine("Введите число. Чтобы закончить введите 0");
        b = Console.ReadLine();
        flag = int.TryParse(b, out a);
        if (!flag)
            Console.WriteLine("Это не число");
        Console.WriteLine("");
    } while (!flag);
    a = Convert.ToInt32(b);
    if (a > 0 && a % 2 > 0)
        text += $"{Convert.ToInt32(a)} ";
        sum += a;
} while (a != 0) ;
Console.WriteLine($"\n{text} \n{sum}");