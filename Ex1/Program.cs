//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
//Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
//Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класс.

string text;
Console.WriteLine("Введите реальную часть 1");
double v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите мнимую часть 1");
double v2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите реальную часть 2");
double v3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите мнимую часть 2");
double v4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Struct or Class");
string a = Console.ReadLine();
if (a == "Struct" || a == "struct")
{
	ComplexS z1 = new ComplexS(v1, v2);
	Console.WriteLine("Struct: " + z1.Text());

	ComplexS z2 = new ComplexS(v3, v4);
	Console.WriteLine("Struct: " + z2.Text());

	ComplexS z3;
	z3 = z1 + z2;
	Console.WriteLine("StructSum: " + z3.Text());

	ComplexS z4;
	z4 = z1 - z2;
	Console.WriteLine("StructSub: " + z4.Text());
}

Console.WriteLine("");

if (a == "Class" || a == "class")
{
	ComplexC x1 = new ComplexC(1, 2);
	Console.WriteLine("Class: " + x1.Text());

	ComplexC x2 = new ComplexC(4, -6);
	Console.WriteLine("Class: " + x2.Text());

	Console.WriteLine("Plus or Minus or Mult");
	string act = Console.ReadLine();
	int g = 0;
	if (act == "Plus" || act == "plus") g = 1;
	else if (act == "Minus" || act == "minus") g = 2;
	else if (act == "Mult" || act == "mult") g = 3;

	switch (g)
	{
		case 1:
			ComplexC x3;
			x3 = x1 + x2;
			Console.WriteLine("ClassSum: " + x3.Text());
			break;
		case 2:
			ComplexC x4;
			x4 = x1 - x2;
			Console.WriteLine("ClassSub: " + x4.Text());
			break;
		case 3:
			ComplexC x5;
			x5 = x1 * x2;
			Console.WriteLine("ClassMult: " + x5.Text());
			break;
	}
}
