//lvu
    Console.Write("Выбери одну из нижеперечисленных операций: " + "\n" +
             "1-сложение\n2-вычитание\n3-умножение\n4-деление\n5-возведение в степень\n");
    int znak = int.Parse(Console.ReadLine());

    void Summation()
    {
    if (znak == 1)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && a < 11 && b > 0 && b < 11)
            {
            int sum = a + b;
                Console.WriteLine("Итог\n" + sum);
            }
            else
            {
            Console.WriteLine("Oшибка, введите числа от 1 до 10!");
            
            }
        }
    }

    void Subtraction()
    {

        if (znak == 2)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && a < 11 && b > 0 && b < 11)
            {
             int sub = a - b;
                Console.WriteLine("Итог\n"+ sub);
            }
            else
            {
                Console.WriteLine("Ошибка, введите числа от 1 до 10!");
                
            }
        }
    }

    void Multiply()
    {
        if (znak == 3)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && a < 11 && b > 0 && b < 11)
            {
                Console.WriteLine("Итог\n" + a * b);
            }
            else
            {
                Console.WriteLine("Ошибка, введите числа от 1 до 10!");
            }
        }
    }

    void Division()
    {
        if (znak == 4)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && a < 11 && b > 0 && b < 11)
            {
                Console.WriteLine("Итог\n" + a / b);
            }
            else
            {
                Console.WriteLine("Ошибка, введите числа от 1 до 10!");
            }
        }
    }

    void Degree()
    {
        if (znak == 5)
        {
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0 && a < 11)
            {
                Console.WriteLine("Итог\n" + a * a);
            }
            else
            {
                Console.Write("Ошибка, введите число от 1 до 10!");
                Console.ReadKey();
            }
        }
       

    }
    Summation();
    Subtraction();
    Multiply();
    Division();
    Degree();

