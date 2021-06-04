using System;
using System.Globalization;

namespace Course2 {
    class ImprimindoVariaveis {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.357533;
            string nome = "Maria";


            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!!");
            Console.WriteLine("Boa noite!!!");


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
        }
    }
}
