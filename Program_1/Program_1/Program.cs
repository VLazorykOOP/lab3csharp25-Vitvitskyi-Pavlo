using System;

class Rectangle
{
    protected int a, b;
    protected int color;

    // Конструктор
    public Rectangle(int a, int b, int color)
    {
        this.a = a;
        this.b = b;
        this.color = color;
    }

    // Вивід довжин сторін
    public void PrintSides()
    {
        Console.WriteLine($"Сторони: {a} x {b}");
    }

    // Обчислення периметра
    public int GetPerimeter()
    {
        return 2 * (a + b);
    }

    // Обчислення площі
    public int GetArea()
    {
        return a * b;
    }

    // Перевірка, чи є квадратом
    public bool IsSquare()
    {
        return a == b;
    }

    // Властивості
    public int A { get => a; set => a = value; }
    public int B { get => b; set => b = value; }
    public int Color { get => color; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть кількість прямокутників: ");
        int n = int.Parse(Console.ReadLine());

        Rectangle[] rectangles = new Rectangle[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть дані для прямокутника {i + 1}:");
            Console.Write("Сторона a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Сторона b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Колір (числовий код): ");
            int color = int.Parse(Console.ReadLine());

            rectangles[i] = new Rectangle(a, b, color);
        }

        int squareCount = 0;
        foreach (Rectangle rect in rectangles)
        {
            rect.PrintSides();
            Console.WriteLine($"Периметр: {rect.GetPerimeter()}");
            Console.WriteLine($"Площа: {rect.GetArea()}");
            Console.WriteLine($"Колір: {rect.Color}");
            if (rect.IsSquare())
            {
                Console.WriteLine("Це квадрат!");
                squareCount++;
            }
            Console.WriteLine("----------------");
        }
        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}