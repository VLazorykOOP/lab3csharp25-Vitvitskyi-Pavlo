using System;
using System.Collections.Generic;

// Базовий клас
abstract class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public abstract void Show();
}

// Похідні класи
class Worker : Employee
{
    public string Position { get; set; }

    public Worker(string name, int age, double salary, string position)
        : base(name, age, salary)
    {
        Position = position;
    }

    public override void Show()
    {
        Console.WriteLine($"Робітник: {Name}, Вік: {Age}, Зарплата: {Salary}, Посада: {Position}");
    }
}

class HR : Employee
{
    public int ManagedPeople { get; set; }

    public HR(string name, int age, double salary, int managedPeople)
        : base(name, age, salary)
    {
        ManagedPeople = managedPeople;
    }

    public override void Show()
    {
        Console.WriteLine($"Кадри: {Name}, Вік: {Age}, Зарплата: {Salary}, Керує: {ManagedPeople} людьми");
    }
}

class Engineer : Employee
{
    public string Specialty { get; set; }

    public Engineer(string name, int age, double salary, string specialty)
        : base(name, age, salary)
    {
        Specialty = specialty;
    }

    public override void Show()
    {
        Console.WriteLine($"Інженер: {Name}, Вік: {Age}, Зарплата: {Salary}, Спеціальність: {Specialty}");
    }
}

class Administration : Employee
{
    public string Department { get; set; }

    public Administration(string name, int age, double salary, string department)
        : base(name, age, salary)
    {
        Department = department;
    }

    public override void Show()
    {
        Console.WriteLine($"Адміністрація: {Name}, Вік: {Age}, Зарплата: {Salary}, Відділ: {Department}");
    }
}

class Program1
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Введіть кількість працівників: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введіть дані для працівника {i + 1}:");
            Console.Write("Ім'я: ");
            string name = Console.ReadLine();
            Console.Write("Вік: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Зарплата: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Виберіть тип (1 - Робітник, 2 - Кадри, 3 - Інженер, 4 - Адміністрація): ");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Console.Write("Посада: ");
                    string position = Console.ReadLine();
                    employees.Add(new Worker(name, age, salary, position));
                    break;
                case 2:
                    Console.Write("Кількість керованих людей: ");
                    int managedPeople = int.Parse(Console.ReadLine());
                    employees.Add(new HR(name, age, salary, managedPeople));
                    break;
                case 3:
                    Console.Write("Спеціальність: ");
                    string specialty = Console.ReadLine();
                    employees.Add(new Engineer(name, age, salary, specialty));
                    break;
                case 4:
                    Console.Write("Відділ: ");
                    string department = Console.ReadLine();
                    employees.Add(new Administration(name, age, salary, department));
                    break;
                default:
                    Console.WriteLine("Невірний вибір типу працівника.");
                    i--;
                    break;
            }
        }

        Console.WriteLine("Працівники (відсортовані за зарплатою):");
        employees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));

        foreach (var emp in employees)
        {
            emp.Show();
        }
    }
}
