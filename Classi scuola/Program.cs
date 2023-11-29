using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            Console.WriteLine("inserisci la materia: ");
            s.id = Console.ReadLine();
            Console.WriteLine("descrivi la materia: ");
            s.descrizione = Console.ReadLine();
            return s;


        }

        private static Persona PersonaStudente()
        {
            Persona p = new Persona();
            Console.WriteLine("nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("cognome: ");
            p.Cognome = Console.ReadLine();
            Console.WriteLine("Data di nascita: ");
            p.Datan = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("voto: ");
            p.voto = int.Parse(Console.ReadLine());
            Console.WriteLine("Data del voto");
            p.Datav = DateTime.Parse(Console.ReadLine());
            return p;
        }
    }
}
