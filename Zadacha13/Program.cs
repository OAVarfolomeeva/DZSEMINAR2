Console.WriteLine("Введите любое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int mod = 0;
if (numberA >= 100)
{
    {while(numberA > 999)
    numberA = numberA / 10;
    }
    mod = numberA % 10;
   Console.WriteLine("Третья цифра: "+ mod);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
