using System;

namespace TypeConversionApplication {
  class ExplicitConversion {
    static void Main(String[] args){
      double double_variable = 3.14235;
      int int_value;

      int_value = (int)double_variable;
      Console.WriteLine($"the original value is {double_variable}");
      Console.WriteLine("the cast value is");
      Console.WriteLine(int_value);
    }
  }
}
