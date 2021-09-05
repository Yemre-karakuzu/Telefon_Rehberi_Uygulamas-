using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class Kisi
    {
        private string firstName;
        private string lastName;
        private int numara;
        public Kisi(string isim, string soyisim, int numara) //Kurucu Metot
        {
            FirstName = isim;
            LastName = soyisim;
            Numara = numara;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Numara { get => numara; set => numara = value; }
    }
}