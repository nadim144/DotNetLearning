using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_setter_getter
{
    class Student
    {
        private int _StudentID;
        private string _StudentName;

        public Student()
        {
            //Default Constructor
        }

        public void setId(int Id)
        {
            if (Id < 0)
            {
                throw new Exception("Sorry ID can not be negative.");
            }
            this._StudentID = Id;
        }

        public int getId()
        {
            return this._StudentID;
        }

        public void setName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Sorry Name can not be empty or null.");
            }
            this._StudentName = name;
        }

        public string getName()
        {
            return this._StudentName;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.setId(100);
            s.setName("Nadim");
            Console.WriteLine("Student Id : {0}", s.getId());
            Console.WriteLine("Student Name : {0}", s.getName());
        }
    }
}
