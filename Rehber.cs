using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Rehber
    {
        private List<Kisi> rehberListesi = new List<Kisi>();
        public Rehber()
        {
        }
        public Rehber(List<Kisi> kisiler)
        {
            RehberListesi = kisiler;
        }
        public List<Kisi> RehberListesi { get => rehberListesi; set => rehberListesi = value; }
        public void KisiEkle(string isim, string soyisim, int numara)
        {
            RehberListesi.Add(new Kisi(isim, soyisim, numara));
        }
        public void RehberiListele()
        {
            Console.WriteLine(" Telefon Rehberi");
            Console.WriteLine("**********************************************");
            for (int i = 0; i < rehberListesi.Count; i++)
            {
                Console.WriteLine("isim : " + rehberListesi[i].FirstName);
                Console.WriteLine("Soyisim : " + rehberListesi[i].LastName);
                Console.WriteLine("Telefon Numarası : " + rehberListesi[i].Numara);
                Console.WriteLine("-------");
            }
        }
        public void ChoseList()
        {
            List<Kisi> kisiler = new List<Kisi>();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine(" *******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Programı Kapat");
            int chose = int.Parse(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    Console.WriteLine("Lütfen isim giriniz: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Lütfen soyisim giriniz: ");
                    string lastName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Lütfen numarayi giriniz: ");
                    int numara = int.Parse(Console.ReadLine());
                    KisiEkle(name, lastName, numara);
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                case 3:
                    Console.WriteLine("Durum 3");
                    break;
                case 4:
                    RehberiListele();
                    break;
                case 5:
                    Console.WriteLine("Durum 5");
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Devam etmek istiyor musunuz ");
            Console.WriteLine("(1)Evet ");
            Console.WriteLine("(2)Hayır ");
            int temp = int.Parse(Console.ReadLine());
            if (temp == 1)
                ChoseList();
            else
                Environment.Exit(0);

        }
        public void rehberiDoldur()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi("Yunus", "Emre", 123456));
            kisiler.Add(new Kisi("Oznur", "Canim", 122456));
            kisiler.Add(new Kisi("Merve", "Kara", 123556));
            kisiler.Add(new Kisi("Ahmet ", "Mehmet", 323456));
            kisiler.Add(new Kisi("Ali", "Veli", 123451));
            RehberListesi = kisiler;
        }
    }
}