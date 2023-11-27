using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_scuola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Studente = PersonaStudente();
            Persona Insegnante = PersonaInsegante();
        }

        private static Persona PersonaInsegante()
        {
            Persona s = new Persona();
            Console.WriteLine("nome: ");
            s.Nome = Console.ReadLine();
            Console.WriteLine("cognome: ");
            s.Cognome = Console.ReadLine();
            Console.WriteLine("Data di nascita: ");
            s.Datan = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("voto: ");
            s.voto = int.Parse(Console.ReadLine());
            Console.WriteLine("Data del voto");
            s.Datav = DateTime.Parse(Console.ReadLine());
            return s;

        }

        private static Persona PersonaStudente()
        {
            Persona s = new Persona();
            Console.WriteLine("nome: ");
            s.Nome = Console.ReadLine();
            Console.WriteLine("cognome: ");
            s.Cognome = Console.ReadLine();
            Console.WriteLine("Data di nascita: ");
            s.Datan = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("voto: ");
            s.voto = int.Parse(Console.ReadLine());
            Console.WriteLine("Data del voto");
            s.Datav = DateTime.Parse(Console.ReadLine());
            return s;
        }
    }
}
