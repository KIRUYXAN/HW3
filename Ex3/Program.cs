/*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей.
Написать программу, демонстрирующую все разработанные элементы класса.
Добавить свойства типа int для доступа к числителю и знаменателю;
Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
Добавить проверку, чтобы знаменатель не равнялся 0.
Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.*/

/*class  x/y =  -inf до +inf/-inf до +inf
x/y + x/y,      Есть
x/y - x/y,      Есть
x/y / x/y,      Есть
x/y * x/y       Есть
int = ReadLine для numerator и denominator       Есть
double для x/y = #,##...     Есть
Проверка y != 0      Есть
Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.*/

int num1, den1, num2, den2;
Console.WriteLine("Введите делитель 1");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите знаменатель 1");
den1 = checkDen();

Console.WriteLine("Введите делитель 2");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите знаменатель 2");
den2 = checkDen();

double rac1 = num1 / den1;
double rac2 = num2 / den2;

Rac z1 = new Rac(num1, den1);
Console.WriteLine($"Rac1: {z1.Text()}\n");

Rac z2 = new Rac(num2, den2);
Console.WriteLine($"Rac2: {z2.Text()}\n\n");


Rac z3;
z3 = z1 + z2;
Console.WriteLine($"Plus: {z3.Text()}\n");

Rac z4;
z4 = z1 - z2;
Console.WriteLine($"Minus: {z4.Text()}\n");

Rac z5;
z5 = z1 * z2;
Console.WriteLine($"Mult: {z5.Text()}\n");

Rac z6;
z6 = z1 / z2;
Console.WriteLine($"Div: {z6.Text()}\n");

int checkDen()
{
    int a;
    do
    {
        a = Convert.ToInt32(Console.ReadLine());
        if (a == 0) Console.WriteLine("Знаменатель не может быть равен 0");
    } while (a == 0);
    return a;
}