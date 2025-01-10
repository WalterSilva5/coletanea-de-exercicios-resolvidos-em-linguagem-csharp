using System;

namespace EnumExampleNamespace
{
    class EnumExample
    {
        enum Example
        {
            FIRST,
            SECOND
        };
        public static void Main(string[] args)
        {
            Console.WriteLine($"The first value in the enum is {Example.FIRST}");
        }
    }
}