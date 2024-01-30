using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_S1_L2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona meStesso = new Persona("Francesco", "Lobbia", 30);


            Console.WriteLine("Nome: " + meStesso.GetNome() );
            Console.WriteLine("Cognome: " + meStesso.GetCognome());
            Console.WriteLine("Età: " + meStesso.GetEta());
            Console.WriteLine("Dettagli: " + meStesso.GetDettagli());

            Persona persona1 = new Persona();
           
            Console.WriteLine(persona1.GetNome() );

            Console.WriteLine("E tu chi sei?");
            string nome = Console.ReadLine();
            Console.WriteLine("Ah quindi tu sei " + nome);
            Console.ReadLine();
        }
    }
}
