int number1 = new int();
Console.WriteLine("Введите число");
number1 = Convert.ToInt32(Console.ReadLine());
int number2 = new int();
Console.WriteLine("Введите число");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Большее число");
if(number1 < number2)
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine(number1);
}