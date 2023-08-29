Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0 ; i < 3 ; i++)
{
    result *= number;
}
Console.WriteLine("Число" + number +  "в кубе равно"  + result);

