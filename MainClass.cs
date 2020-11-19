using System;

namespace ConsoleApp3
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            DerivedClass DC = new DerivedClass();
            DC.FirstName = "Som";
            DC.LastName = "Roy";
            DC.GetName();

        }
    }

    public class MySealedClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public MySealedClass() { Console.WriteLine("I m Base Class!!!!"); }

        public virtual string GetName()
        {
            return string.Format("{0}, {1}", FirstName, LastName);
        }
    }

    public class DerivedClass : MySealedClass
    {
        public override sealed string GetName()
        {
            Console.WriteLine("I m Child's Method!!!!");
            return string.Format("{0}, {1}", FirstName, LastName);
        }
    }

    public class NextDerivedClass : MySealedClass
    {
        public override string GetName()
        {
            return "";
        }
    }
}
