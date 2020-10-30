using System;

namespace Polymorphism
{
    /* polymorphism is basically enables you to invoke derived class method
     * through base class referance variables at runtime*/

    public class Base
    {
        public string firstName = "First";
        public string lastName = "Last";

        public virtual void Print()
        {
            Console.WriteLine("Base print called!");
            Console.WriteLine(firstName + " " + lastName + " " + "Base");
        }
    }

    public class Derived : Base
    {
        public override void Print()
        {
            Console.WriteLine("Derived print called!");
            Console.WriteLine(firstName + " " + lastName + " " + "Derived");
        }
    }

    public class Derived1 : Base
    {
        public override void Print()
        {
            Console.WriteLine("Derived 1 print called!");
            Console.WriteLine(firstName + " " + lastName + " " + "Derived1");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Base[] bases = new Base[3];
            bases[0] = new Base();
            bases[1] = new Derived();
            bases[2] = new Derived1();

            foreach (Base @base in bases)
            {
                @base.Print();
            }

            /* OUTPUT */

            //  Base print called!
            //  First Last Base
            //  Derived print called!
            //  First Last Derived
            //  Derived 1 print called!
            //  First Last Derived1
        }
    }
}