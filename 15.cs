using System;

namespace Xyz
{
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            Console.WriteLine("Student Info");
            obj.acceptp();
            Console.WriteLine("Student-Course Info");
            obj.acceptc();

            Console.WriteLine("Student Details:");
            obj.displayp();
            obj.displayc();
            Console.ReadKey();
        }
    }

    public interface Iperson
    {
        void acceptp();
        void displayp();
    }

    public interface Icourse
    {
       void acceptc();
        void displayc();
    }

    class student: Iperson, Icourse 
    {
        string name, fname, course;
        int sem;
        
        public void acceptp()
        {
            Console.WriteLine("Enter name and fname:");
            name = Console.ReadLine();
            fname = Console.ReadLine();
        }

        public void displayp()
        {
            Console.WriteLine("Name=" +name);
            Console.WriteLine("Fname=" +fname);
        }

        public void acceptc()
        {
            Console.WriteLine("Enter Course and Semester:");
            course = Console.ReadLine();
            sem =Convert.ToInt32( Console.ReadLine());
        }

        public void displayc()
        {
            Console.WriteLine("course=" + course);
            Console.WriteLine("semester=" + sem);
        }
    }
}
