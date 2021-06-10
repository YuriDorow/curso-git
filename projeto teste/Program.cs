using System;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O Yuri é Lindão?: ");
            string resp = Console.ReadLine();

            if (resp == "sim" || resp == "SIM")
            {
                Console.WriteLine("Parbéns você acertou!");
            }
            else if (resp == "não" || resp == "NÃO")
            {
                Console.WriteLine("Você é um idiota");
            }
            else if (resp == "Te gosto")
            {
                Console.WriteLine("Também te gosto :)");
            }
            else
            {
                Console.WriteLine("Nah! Resposta errada!");
            }
        }
    }
}
