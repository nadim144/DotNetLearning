using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_get_set
{
    class Student
    {
        private int _studId;
        private string _studName;
        private int _passMark;

        public Student()
        {
            //Default Contructor
            _passMark = 30;
        }

        public int StudID
        {
            set
            {
                if(value <0)
                {
                    throw new Exception("Student ID Can not be negative.");
                }
                this._studId = value;
            }
            get
            {
                return this._studId;
            }
        }

        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student Name can not be empty or null.");
                }
                this._studName = value;
            }
            get
            {
                return this._studName;
            }
        }

        public int Mark
        {
            get
            {
                return this._passMark;
            }
        }
    }

    class Customer
    {
        public int custId { get; set; }
        public string custName { get; set; }
        public string custCity { get; set; }

        public Customer()
        {
            //Default Constructor
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.StudID = 102;
            s.Name = "Ahmad";

            Console.WriteLine("Student ID: {0}", s.StudID);
            Console.WriteLine("Student Name: {0}", s.Name);
            Console.WriteLine("Student Pass Mark: {0}", s.Mark);

            Customer c = new Customer();
            c.custId = 105;
            c.custName = "Elxtron";
            c.custCity = "Bangelore";

            Console.WriteLine("Customer ID : {0}", c.custId);
            Console.WriteLine("Customer Name : {0}", c.custName);
            Console.WriteLine("Customer City : {0}", c.custCity);
        }
    }
}
