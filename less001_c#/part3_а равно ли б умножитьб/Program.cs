Console.Clear();
Console.Write("Введите число1:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if ((num1 == num2 * num2) || (num2 == num1 * num1))

{
   Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

