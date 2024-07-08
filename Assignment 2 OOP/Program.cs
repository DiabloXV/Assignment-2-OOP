using System;
using System.Globalization;


namespace Assignment_2_OOP
{
    internal class Program
    {
        /*                   Part 1                          */
        #region Struct With Indexer
        //public struct Point
        //{
        //    private double _x;
        //    private double _y;

        //    public Point(double x, double y)
        //    {
        //        _x = x;
        //        _y = y;
        //    }

        //    public double X
        //    {
        //        get { return _x; }
        //        set { _x = value; }
        //    }

        //    public double Y
        //    {
        //        get { return _y; }
        //        set { _y = value; }
        //    }

        //    public double this[int index]
        //    {
        //        get
        //        {
        //            if (index == 0)
        //                return _x;
        //            else if (index == 1)
        //                return _y;
        //            else
        //                throw new IndexOutOfRangeException("Index must be 0 or 1");
        //        }
        //        set
        //        {
        //            if (index == 0)
        //                _x = value;
        //            else if (index == 1)
        //                _y = value;
        //            else
        //                throw new IndexOutOfRangeException("Index must be 0 or 1");
        //        }
        //    }


        //    public double DistanceTo(Point other)
        //    {
        //        double dx = _x - other._x;
        //        double dy = _y - other._y;
        //        return Math.Sqrt(dx * dx + dy * dy);
        //    }
        //}
        #endregion

        #region Struct without an indexer
        //public struct Rectangle
        //{
        //    private double _width;
        //    private double _height;

        //    public Rectangle(double width, double height)
        //    {
        //        _width = width;
        //        _height = height;
        //    }

        //    public double Width
        //    {
        //        get { return _width; }
        //        set { _width = value; }
        //    }

        //    public double Height
        //    {
        //        get { return _height; }
        //        set { _height = value; }
        //    }

        //    public double GetArea()
        //    {
        //        return _width * _height;
        //    }

        //    public double GetPerimeter()
        //    {
        //        return 2 * (_width + _height);
        //    }
        //}
        #endregion

        #region Parent class
        //public class Animal
        //{
        //    private string _name;
        //    private int _age;

        //    public Animal(string name, int age)
        //    {
        //        _name = name;
        //        _age = age;
        //    }

        //    public string Name
        //    {
        //        get { return _name; }
        //        set { _name = value; }
        //    }

        //    public int Age
        //    {
        //        get { return _age; }
        //        set { _age = value; }
        //    }

        //    public virtual void MakeSound()
        //    {
        //        Console.WriteLine("The animal makes a sound.");
        //    }
        //}
        #endregion

        #region Child clss
        //public class Dog : Animal
        //{
        //    private string _breed;

        //    public Dog(string name, int age, string breed) : base(name, age)
        //    {
        //        _breed = breed;
        //    }

        //    public string Breed
        //    {
        //        get { return _breed; }
        //        set { _breed = value; }
        //    }

        //    public override void MakeSound()
        //    {
        //        Console.WriteLine("The dog barks.");
        //    }

        //    public void Fetch()
        //    {
        //        Console.WriteLine($"{Name} is fetching the ball.");
        //    }
        //}
        #endregion


        /*                   part 2                          */
        #region Employee class
        //public enum SecurityLevel
        //{
        //    Guest,
        //    Developer,
        //    Secretary,
        //    DBA,
        //    SecurityOfficer
        //}

        //public class Employee
        //{
        //    #region Fields
        //    private string _id;
        //    private string _name;
        //    private SecurityLevel _securityLevel;
        //    private decimal _salary;
        //    private HiringDate _hireDate;
        //    private char _gender;
        //    #endregion

        //    #region Properties
        //    public string ID
        //    {
        //        get { return _id; }
        //        set
        //        {
        //            if (string.IsNullOrEmpty(value)) throw new ArgumentException("ID cannot be null or empty");
        //            _id = value;
        //        }
        //    }

        //    public string Name
        //    {
        //        get { return _name; }
        //        set
        //        {
        //            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Name cannot be null or empty");
        //            _name = value;
        //        }
        //    }

        //    public SecurityLevel SecurityLevel
        //    {
        //        get { return _securityLevel; }
        //        set { _securityLevel = value; }
        //    }

        //    public decimal Salary
        //    {
        //        get { return _salary; }
        //        set
        //        {
        //            if (value < 0) throw new ArgumentException("Salary cannot be negative");
        //            _salary = value;
        //        }
        //    }

        //    public HiringDate HireDate
        //    {
        //        get { return _hireDate; }
        //        set { _hireDate = value; }
        //    }

        //    public char Gender
        //    {
        //        get { return _gender; }
        //        set
        //        {
        //            if (value != 'M' && value != 'F') throw new ArgumentException("Gender must be 'M' or 'F'");
        //            _gender = value;
        //        }
        //    }
        //    #endregion

        //    #region Constructors
        //    public Employee(string id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        //    {
        //        ID = id;
        //        Name = name;
        //        SecurityLevel = securityLevel;
        //        Salary = salary;
        //        HireDate = hireDate;
        //        Gender = gender;
        //    }
        //    #endregion

        //    #region Methods
        //    public override string ToString()
        //    {
        //        return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}, Hire Date: {HireDate}, Gender: {Gender}";
        //    }
        //    #endregion
        //}
        #endregion

        #region Hiring Date Class
        //public class HiringDate
        //{
        //    #region Fields
        //    private int _day;
        //    private int _month;
        //    private int _year;
        //    #endregion

        //    #region Properties
        //    public int Day
        //    {
        //        get { return _day; }
        //        set
        //        {
        //            if (value < 1 || value > 31) throw new ArgumentException("Day must be between 1 and 31");
        //            _day = value;
        //        }
        //    }

        //    public int Month
        //    {
        //        get { return _month; }
        //        set
        //        {
        //            if (value < 1 || value > 12) throw new ArgumentException("Month must be between 1 and 12");
        //            _month = value;
        //        }
        //    }

        //    public int Year
        //    {
        //        get { return _year; }
        //        set
        //        {
        //            if (value < 1900 || value > DateTime.Now.Year) throw new ArgumentException("Year must be a valid year");
        //            _year = value;
        //        }
        //    }
        //    #endregion

        //    #region Constructors
        //    public HiringDate(int day, int month, int year)
        //    {
        //        Day = day;
        //        Month = month;
        //        Year = year;
        //    }
        //    #endregion

        //    #region Methods
        //    public override string ToString()
        //    {
        //        return $"{Day}/{Month}/{Year}";
        //    }
        //    #endregion
        //}
        #endregion
        static void Main(string[] args)
        {
            /*                   Part 1                          */
            #region Main code for Struct with indexer
            //Point p1 = new Point(3, 4);
            //Point p2 = new Point(6, 8);

            //Console.WriteLine($"Distance between points: {p1.DistanceTo(p2)}");
            //Console.WriteLine($"p1[0] = {p1[0]}, p1[1] = {p1[1]}");
            //p1[0] = 7;
            //p1[1] = 10;
            //Console.WriteLine($"After modification: p1[0] = {p1[0]}, p1[1] = {p1[1]}");
            #endregion

            #region Main code for struct without an indexer
            //Rectangle rect = new Rectangle(5, 10);

            //Console.WriteLine($"Width: {rect.Width}, Height: {rect.Height}");
            //Console.WriteLine($"Area: {rect.GetArea()}");
            //Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

            //rect.Width = 7;
            //rect.Height = 12;

            //Console.WriteLine($"After modification - Width: {rect.Width}, Height: {rect.Height}");
            //Console.WriteLine($"New Area: {rect.GetArea()}");
            //Console.WriteLine($"New Perimeter: {rect.GetPerimeter()}");
            #endregion

            #region Class inheritance demonstration
            //Animal genericAnimal = new Animal("Generic Animal", 5);
            //genericAnimal.MakeSound();

            //Dog myDog = new Dog("Buddy", 3, "Golden Retriever");
            //myDog.MakeSound();
            //myDog.Fetch();

            //Console.WriteLine($"Name: {myDog.Name}, Age: {myDog.Age}, Breed: {myDog.Breed}");
            #endregion


            /*                   Part 2                            */
            #region Main code for part 2
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee("E001", "Alice", SecurityLevel.DBA, 60000, new HiringDate(15, 6, 2015), 'F');
            //EmpArr[1] = new Employee("E002", "Bob", SecurityLevel.Guest, 30000, new HiringDate(1, 1, 2020), 'M');
            //EmpArr[2] = new Employee("E003", "Charlie", SecurityLevel.SecurityOfficer, 70000, new HiringDate(10, 10, 2010), 'M');

            //foreach (var employee in EmpArr)
            //{
            //    Console.WriteLine(employee);
                
            //}
            #endregion
        }
    }
}
