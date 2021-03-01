using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStd = new Student();
            
           
            Console.WriteLine("College Name = {0}", objStd.CollegeName);

            
            objStd.Remarks = "Welcome";
            

            
            objStd.Name = "Akshay";
            Console.WriteLine("Name : {0}", objStd.Name);

            Console.ReadKey();
        }
    }

    class Student
    {
        string collegeName="ABC", name, remarks;

        
        public string CollegeName
        {
            get
            {
                return collegeName;
            }
        }

        
        public string Remarks
        {
            set
            {
                remarks = value;
            }
        }

        
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        
    }
}
