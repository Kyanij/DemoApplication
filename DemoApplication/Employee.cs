using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    interface IPerson
    {
        void getName(); //method 
        void setName(string name);

        void getAge();
    }

    interface IPerson2
    {
        void setAge(int age);
    }
    public class Student : Person
    {
        public Student() { }

        public override void secondMethod()
        {
            Console.WriteLine("Student second method");
        }
    }
    public class Employee : Person
    {
        public int Id;
        public string Name;
        public string Department;

        public void DisplayName()
        {
            Console.WriteLine("Name = " + Name);
        }

        public override void myMethod()
        {
            Console.WriteLine("Called from child class");
        }

        public override void secondMethod()
        {
            Console.WriteLine("testing");
        }
    }

    public abstract class Person  : IPerson, IPerson2
    {
        public string gender;

        public void getAge()
        {
            throw new NotImplementedException();
        }

        public void getName()
        {
            throw new NotImplementedException();
        }

        public virtual void myMethod()

        {
            Console.WriteLine("called from parent class");
        }

        public abstract void secondMethod();

        public void setAge(int age)
        {
            throw new NotImplementedException();
        }

        public void setName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
