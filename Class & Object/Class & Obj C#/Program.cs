﻿public class Student
{
    public int id;
    public String name = "";
    public void insert(int i, String n)
    {
        id = i;
        name = n;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name);
    }
}

public class Employee
{
    public int id;
    public String name = "";
    public float salary;
    public void insert(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}

namespace Class___Obj_C_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.insert(101, "Ajeet");
            s2.insert(102, "Tom");
            s1.display();
            s2.display();

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            e1.insert(101, "Sonoo", 890000f);
            e2.insert(102, "Mahesh", 490000f);
            e1.display();
            e2.display();

        }
    }
}
