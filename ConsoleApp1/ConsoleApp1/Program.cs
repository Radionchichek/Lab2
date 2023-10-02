// See https://aka.ms/new-console-template for more information
using System;

// Клас Address
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

// Клас Converter
class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double usdAmount)
    {
        return usdAmount * usd;
    }

    public double ConvertFromEUR(double eurAmount)
    {
        return eurAmount * eur;
    }

    public double ConvertFromPLN(double plnAmount)
    {
        return plnAmount * pln;
    }
}

// Клас Employee
class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public double CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;

        // Ось приклад розрахунку окладу в залежності від посади і стажу
        if (position == "Менеджер")
        {
            baseSalary = 50000;
        }
        else if (position == "Розробник")
        {
            baseSalary = 60000;
        }

        double tax = baseSalary * 0.15; // Податковий збір

        return baseSalary + (experience * 1000) - tax;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
    }
}

// Клас User
class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        registrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання класу Address
        Address address = new Address();
        address.Index = "12345";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Вулиця Київська";
        address.House = "10";
        address.Apartment = "42";

        Console.WriteLine("Адреса:");
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

        // Приклад використання класу Converter
        Converter converter = new Converter(27.5, 33.0, 7.0);
        double amountInUAH = 1000.0;

        double usdAmount = converter.ConvertToUSD(amountInUAH);
        double eurAmount = converter.ConvertToEUR(amountInUAH);
        double plnAmount = converter.ConvertToPLN(amountInUAH);

        Console.WriteLine($"1000 грн = {usdAmount} USD");
        Console.WriteLine($"1000 грн = {eurAmount} EUR");
        Console.WriteLine($"1000 грн = {plnAmount} PLN");

        // Приклад використання класу Employee
        Employee employee = new Employee("Іванов", "Петро");
        string position = "Менеджер";
        int experience = 5;

        double salary = employee.CalculateSalary(position, experience);

        Console.WriteLine($"Співробітник:");
        employee.DisplayInfo();
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Заробітна плата: {salary} грн");

        // Приклад використання класу User
        User user = new User("user123", "Іван", "Петрович", 30);

        Console.WriteLine($"Користувач:");
        user.DisplayInfo();

        Console.ReadLine();
    }
}