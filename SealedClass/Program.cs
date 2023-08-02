using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    /*sealed class parent */
    class parent 
    {
        public void show1()
        {
            Console.WriteLine(" method of parent class");

        }
    }
    class child : parent
    {
        public void show2()
        {
            Console.WriteLine(" method of child class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            parent obj1 = new parent();
            obj1.show1();
            child obj2 = new child();
            obj2.show2();
            obj2.show1 ();


            Console.ReadLine();
        }
    }
}
