Console.Write("Введите число 1: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число 2: ");
        int m = Convert.ToInt32(Console.ReadLine());
        for (int i = n; i <= m; i= i+1)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
