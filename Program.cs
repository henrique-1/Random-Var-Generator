using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Variable_Generator
{
    class Program
    {
        private static string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        static void Main(string[] args)
        {
            int varsize = 0;

            Console.Write("Qual o tamanho da sua variável: ");
            try
            {
                varsize = int.Parse(Console.ReadLine());
            }
            catch {
                Console.Write("Flw.");
                Thread.Sleep(250);
                return;
            }


            if (varsize > 150)
            {
                Console.Write("Ae meu praça, {0} caracteres? Tu quer me fuder porra? FLW!!!", varsize.ToString());
                Console.WriteLine("O Tamanho máximo da variável é de 150 caractéres.");
                Thread.Sleep(1250);
                return;
            }

            string randvar = "";
            Console.WriteLine("A sua variável será gerada com {0} caracteres, gerados randomicamente.", varsize.ToString());
            Thread.Sleep(1000);

            Random r = new Random();

            char[] senha = new char[varsize];

            for (int i = 0; i < senha.Length; i++)
            {
                senha[i] = charset[r.Next(0, charset.Length)];
            }

            Console.WriteLine("A sua váriavel foi gerada.");
            Console.WriteLine("\n\nA sua nova váriável é: ");
            Console.WriteLine(new string(senha));

            Console.ReadKey();
            
        }
    }
}
