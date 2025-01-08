using System;

class TextInputProgram{
  public static void Main(string[] args){
    string text_variable;
    Console.WriteLine("Digite um valor para entrada: ");
    text_variable = Console.ReadLine();
    Console.WriteLine($"text value: {text_variable}");
  }
}
