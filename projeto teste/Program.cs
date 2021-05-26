using System;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("O Yuri é Lindão?: ");
            string resp = Console.ReadLine();

            if (resp == "sim")
            {
                Console.WriteLine("Parbéns você acertou!");
            }
            else
            {
                Console.WriteLine("Nah! Resposta errada!");
            }
        }
    }
}
