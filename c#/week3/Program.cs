using System;

namespace week3
{
    public class Person
    {
        protected int age;
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }

    }
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {this.age} years old");
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
        public string Subject { set; get; }

    }
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Greet();

            var student = new Student();
            student.SetAge(21);
            student.Greet();
            student?.ShowAge();
            

            var teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
