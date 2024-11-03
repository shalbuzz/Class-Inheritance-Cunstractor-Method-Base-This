using System;
using Class_Inheritance_Cunstractor_Method_Base_This;

namespace Class_Inheritance_Cunstractor_Method_Base_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            // human.Name = "Shalbuz";
            // human.Surname = "Aliverdiyev";
            // human.Age = 19;
            // Console.WriteLine(human.Surname);
            // human.ShowFullData();

            // Teacher teacher = new Teacher();
            // teacher.Name = "Shalbuz";
            // teacher.Surname = "Aliverdiyev";
            // teacher.Age = 20;
            // teacher.Salary = 340;
            // Console.WriteLine(teacher.Salary);

            // Teacher teacher1 = new Teacher
            // {
            //     Name = "Test",
            //     Surname = "Testov",
            //     Age = 19,
            //     Salary = 20,

            // };


            // Student student = new Student();
            // student.Name = teacher.Name;
            // student.Surname= teacher.Surname;
            // student.Age = teacher.Age;
            // student.Grant = 3409;
            // student.GroupNo = "PB-503";
            // Console.WriteLine(student.Name);

            // Student student1 = new Student();
            // student1.Surname = "baxisov";
            // student1.Name = "salam";
            // student1.Age = 20;
            // student1.Grant = 40;
            // student1.GroupNo = "pb456";
            // Console.WriteLine(student1.Surname);

            // Student student2 = student1;
            // student2.Name = "Agabbas";
            // Console.WriteLine(student1.Name);


            // Machine machine = new Machine("BMW", 2015, 2300);
            // Console.WriteLine(machine.Model);
            // Console.WriteLine(machine.Salaries);
            // //machine.ShowFullData();

            // string machine1 = machine.GetFullData();
            // Console.WriteLine(machine1);
            // int machine2 = machine1.IndexOf("Year");
            // Console.WriteLine(machine2);
            // string year = machine1.Substring(machine2);
            // Console.WriteLine(year);

            //Developer developer = new Developer("name", "surname", 2.5);
            BackendDeveloper backendDeveloper = new BackendDeveloper("name", "surname", 2.5);
            backendDeveloper.SqlExperience = 1;

            FrontendDeveloper frontendDeveloper = new FrontendDeveloper("Ruslan", "Abassov", 23);
            frontendDeveloper.ShowFullData();
        }
    }

    #region Class

    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;


        public void ShowFullData()
        {
            Console.WriteLine($"{Name}, {Surname}, {Age}");
        }

       
    }

    public class Teacher: Human
    {
       
        public double Salary;



        
    }

    public class Student:Human
    {
       
        public double Grant;
        public string GroupNo;


        public Student()
        {
            Console.WriteLine("student yarandi");
        }
    }
}
    #endregion

#region Constructor
public class Machine
{
    public string Model;
    public int Year;
    public int Salaries =19900;


    public Machine()
    {
        
    }
    public Machine(string model):this()
    {
        this.Model = model;
    }


    public Machine(string model, int year) :this(model)
    {
       
        this.Year = year;
    }
    public Machine(string model, int year, int salaries) :this(model,year)
    {
        
        this.Salaries = salaries;
    }

    public void ShowFullData()
    {
        Console.WriteLine($"{Model}, {Year}, {Salaries}");
    }

    public string GetFullData()
    {
        return $"Model:{Model},Year: {Year}, Salaries:{Salaries}";
    }

}
#endregion


