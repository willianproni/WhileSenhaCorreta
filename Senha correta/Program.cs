using System;

namespace Senha_correta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("--Teste de senha--");

            Console.Write("\nDigite a senha: ");
            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 2002)
            {
                Console.Write("\nDigite a senha: ");
                senha = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Senha correta");
        }
    }
}
