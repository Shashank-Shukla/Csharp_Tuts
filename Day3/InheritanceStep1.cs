using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp3_11Nov20
{
    class Person
    {
        public string name;//public field, accessible outside of class
        DateTime dob; //private field, accessible only within class

        public Person(string nam, DateTime dob)
        {
            this.name = nam;
            this.dob = dob;
        }
        //get, set methods
        //constructor

        //property encapsulates get & set method
        //get method to read value
        //set method to assign value
       public string DOB  //readonly property
        {
            get {
                return dob.Month.ToString() + "-" + dob.Day.ToString();
            }
            //set {
            //    dob = value;    //keyword
            //}
        }

        public int GetAge()
        {
            int currentyear = DateTime.Today.Year;
            int bornyear = dob.Year;
            return currentyear - bornyear;
        }
        
        public virtual string GetInfo(){
            return $"{this.name}'s born on {this.DOB} and is {this.GetAge()} years young!";
        }
    }
/*
    class PersonClient
    {
        public static void Main()
        {
            Person p = new Person("riya",new DateTime(2012,11,12));
            

            Console.WriteLine($"{p.name}'s Born day is {p.DOB}");
            Console.WriteLine($"{p.name} is {p.GetAge()} years young");
        }
    }*/
    
    class Student:Person
    {
        public int RollNo { get; set; }
        public string Course { get; set; }

        public Student(string name, DateTime dob, int rollno, string course):base(name,dob) //calling base class constructor
        {
            this.RollNo = rollno;
            this.Course = course;
        }
        
        public override string GetInfo()    //overriding base class method
        {
            return $"{base.GetInfo()}, Rollno={this.RollNo}, Course={this.Course}";
        }
    }

    class InheritanceDemo
    {
        public static void Main()
        {
            Student s = new Student("Shashank", new DateTime(1998, 2, 11), 18845, "MS-C#");
            Console.WriteLine($"{s.name} ({s.RollNo}) is {s.GetAge()} years young and pursuing {s.Course}");
        }
    }
}
