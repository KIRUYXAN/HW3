//*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей.
//Написать программу, демонстрирующую все разработанные элементы класса.
//Добавить свойства типа int для доступа к числителю и знаменателю;
//Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//**Добавить проверку, чтобы знаменатель не равнялся 0.
//Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//***Добавить упрощение дробей.
string delitel;
//  class  x/y =  -inf do +inf/-inf do +inf
//      x/y + x/y,
//      x/y - x/y,
//      x/y / x/y,      Есть
//      x/y * x/y       Есть
//      int = ReadLine для numerator и denominator       Есть
//      double для x/y = #,##...     Есть
//      Проверка y != 0
//      Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//      Добавить упрощение дробей.

Console.WriteLine("Введите делитель 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знаменатель 1");
int den1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знаминатель 2");
int den2 = Convert.ToInt32(Console.ReadLine());

double rac1 = num1 / den1;
double rac2 = num2 / den2;

Rac z1 = new Rac(num1, den1);
Console.WriteLine($"Rac1: {z1.Text()}\n");

Rac z2 = new Rac(num2, den2);
Console.WriteLine($"Rac2: {z2.Text()}\n");

Rac z3;
z3 = z1 * z2;
Console.WriteLine($"Mult: {z3.Text()}\n");

Rac z4;
z4 = z1 / z2;
Console.WriteLine($"Div: {z4.Text()}\n");