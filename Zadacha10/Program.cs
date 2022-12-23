int number = new Random().Next(100, 1000);
Console.WriteLine("Введите случйное число:" + number);
string stringNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);