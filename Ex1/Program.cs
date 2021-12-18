//а) ƒописать структуру Complex, добавив метод вычитани€ комплексных чисел.
//ѕродемонстрировать работу структуры.
//б) ƒописать класс Complex, добавив методы вычитани€ и произведени€ чисел.
//ѕроверить работу класса.
//в) ƒобавить диалог с использованием switch демонстрирующий работу класс.

Console.WriteLine("Struct or Class");
string a = Console.ReadLine();
if (a == "Struct" || a == "struct")
{
	ComplexS z1 = new ComplexS(1, 2);
	Console.WriteLine("Struct: " + z1.Print());

	ComplexS z2 = new ComplexS(4, -6);
	Console.WriteLine("Struct: " + z2.Print());

	ComplexS z3;
	z3 = z1.Sum(z2);
	Console.WriteLine("StructSum: " + z3.Print());
	z3 = z1 + z2;
	Console.WriteLine("StructSum: " + z3.Print());

	ComplexS z4;
	z4 = z1 - z2;
	Console.WriteLine("StructSub: " + z4.Print());
}

Console.WriteLine("");

if (a == "Class" || a == "class")
{
	ComplexC x1 = new ComplexC(1, 2);
	Console.WriteLine("Class: " + x1.Print());

	ComplexC x2 = new ComplexC(4, -6);
	Console.WriteLine("Class: " + x2.Print());

	Console.WriteLine("Plus or Minus or Mult");
	string act = Console.ReadLine();
	int g = 0;
	if (act == "Plus" || act == "plus")
		g = 1;
	else if (act == "Minus" || act == "minus")
		g = 2;
	else if (act == "Mult" || act == "mult")
		g = 3;

	switch (g)
	{
		case 1:
			ComplexC x3;
			x3 = x1.Sum(x2);
			Console.WriteLine("ClassSum: " + x3.Print());
			x3 = x1 + x2;
			Console.WriteLine("ClassSum: " + x3.Print());
			break;
		case 2:
			ComplexC x4;
			x4 = x1 - x2;
			Console.WriteLine("ClassSub: " + x4.Print());
			break;
		case 3:
			ComplexC x5;
			x5 = x1 * x2;
			Console.WriteLine("ClassMult: " + x5.Print());
			break;
	}
}
