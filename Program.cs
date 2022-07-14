void Upr1()
    {
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine("Число " + number1 + " больше, чем " + number2);
    }
    else
    {
     Console.WriteLine("Число " + number2 + " больше, чем " + number1);   
    }
    }

void Upr2()
{
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третие число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2 && number1 > number3)
    {
        Console.Write("Самое большое число: " + number1);
    }
    else if (number2 > number3)
    {
        Console.Write("Самое большое число: " + number2);
    }
    else
    {
        Console.Write("Самое большое число: " + number3);
    }
}

void Upr3()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
    {
        Console.Write("Четное");
    }
    else
    {
        Console.Write("нечетное");
    }
}

void Upr4()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int X=2;
    if (number < 2)
    {
        Console.Write("В этом числе нет четных цифор");
    }
    while (number >= X)
    {
        Console.Write(X + ",");
        X+=2;
    }
    Console.Write("\b.");
    Console.WriteLine();
}
    Upr4();