using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person_Opgave_Ny
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public string Adresse;
        public int PostNr;
        public string By;

        

        public string UdskrivPerson()
        {
            return Fornavn + " " + Adresse;
        }
    }
}
