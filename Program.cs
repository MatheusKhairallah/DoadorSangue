using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua idade: ");
            double idade=Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(idade>18 && idade<67)
            Console.WriteLine("Você pode ser doador de sangue");
            else
            Console.WriteLine("Você não pode ser doador de sangue");
        }
    }
}
