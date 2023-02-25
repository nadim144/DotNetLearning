using System;

namespace Interface_1
{
    interface ICustomer
    {
        //public void print() //Ex-1 Interface can not have implementation. It can contain only declaration
        //{
        //    //TODO
        //}

        //int id; // Example-3 Interface can not have field

        //public void print(); //Example -2 // No need to specify public or private, bydfault it is public. Error
        void Print();
    }

    class Customer : ICustomer
    {
        public void Print()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
