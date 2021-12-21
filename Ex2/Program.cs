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
        input(); 
    } while (!flag);
} while (a != 0) ;
Console.WriteLine($"\n{text} \n{sum}");

void input()
{
    Console.WriteLine("Введите число. Чтобы закончить введите 0");
    b = Console.ReadLine();
    flag = int.TryParse(b, out a);
    if (!flag)
        Console.WriteLine("Это не число");
    else
        a = Convert.ToInt32(b);
        Add(a);
    Console.WriteLine("");
}

void Add(int x)
{
    if (x > 0 && x % 2 != 0)
    {
        text += $"{x} ";
        sum += x;
    }
}