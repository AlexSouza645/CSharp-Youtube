using System;
namespace MeuPrograma
{
    class EstudoC{
        static void Main(string[] args)
    {
        char c;
        string str;
        Console.WriteLine("digite seu nome");
        str = Console.ReadLine();
        Console.WriteLine("digite uma letra");
        c = (char)Console.Read();
        Console.WriteLine();
        Console.WriteLine("seu nome é : {0}", str);
        Console.WriteLine("a letra é : {0}", c.ToString());
        Console.ReadLine();    

    }
        }
}