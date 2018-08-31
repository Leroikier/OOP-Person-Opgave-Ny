using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person_Opgave_Ny
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Fornavn = "Jens", Efternavn = "Hansen", Adresse = "Nybrovej 14", PostNr = 2800, By = "Kattestrup" };

            Console.WriteLine(p1.UdskrivPerson());

            Console.ReadKey();
        }
    }
}
