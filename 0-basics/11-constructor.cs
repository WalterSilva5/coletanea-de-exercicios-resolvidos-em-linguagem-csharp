using System;

namespace ConstructorNamespace
{
    class ExampleConsctructor
    {
        public ExampleConsctructor()
        {
            Console.WriteLine("This is the class constructor being called");
        }

        ~ExampleConsctructor(){
            Console.WriteLine("Example destructor being called");
        }
    }

    class ExampleOfUse
    {
        public static void Main(string[] args)
        {
            ExampleConsctructor example = new ExampleConsctructor();
            Console.WriteLine("The class is already created");
        }
    }
}