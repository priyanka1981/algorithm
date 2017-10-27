using System;
namespace Algorithms.polymorphism
{
    public class Base
    {
        //static void Main(string[] args)  
        //{  
        //Base bc = new Base();  
        //Derived dc = new Derived();  
        //Base bcdc = new Derived();  

        //bc.Method1();  
        //dc.Method1();  
        ////dc.Method2();  
        //bcdc.Method1();  
        //} 

        public Base()
        {
        }

        public void Method1()
        {
            Console.WriteLine("Base class Method1..");
        }
    }

    public class Derived : Base
    {
        public Derived(){}
        public new void Method1()
        {
            Console.WriteLine("Derived Class Method1");
        }
    }
}
