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

            foreach (var item in RehberListesi)
            {
                Console.WriteLine("isim : " + item.FirstName);
                Console.WriteLine("Soyisim : " + item.LastName);
                Console.WriteLine("Telefon Numarası : " + item.Numara);
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
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string silinecekKisi = Convert.ToString(Console.ReadLine());
                    kisiSil(silinecekKisi);
                    break;
                case 3:
                    Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    string guncellenecekKisi = Convert.ToString(Console.ReadLine());
                    kisiBilgisiGuncelle(guncellenecekKisi);
                    break;
                case 4:
                    RehberiListele();
                    break;
                case 5:
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                    Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                    int arama = int.Parse(Console.ReadLine());
                    kisiAra(arama);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            programDursunMu();

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
        public void kisiAra(int secenek)
        {
            bool flag = false;
            if (secenek == 1)
            {
                Console.WriteLine("İsim veya soyisime giriniz!: ");
                string arama = Convert.ToString(Console.ReadLine());
                for (int i = 0; i < rehberListesi.Count; i++)
                {
                    if (rehberListesi[i].FirstName == arama || rehberListesi[i].LastName == arama)
                    {
                        Console.WriteLine("isim : " + rehberListesi[i].FirstName);
                        Console.WriteLine("Soyisim : " + rehberListesi[i].LastName);
                        Console.WriteLine("Telefon Numarası : " + rehberListesi[i].Numara);
                        Console.WriteLine("-------");
                        flag = true;
                    }
                }
                if (!flag) Console.WriteLine("Aranan Kişi Bulunamadı! ");
            }
            else
            {
                Console.WriteLine("Numara giriniz!: ");
                int arama = int.Parse(Console.ReadLine());
                for (int i = 0; i < rehberListesi.Count; i++)
                {
                    if (rehberListesi[i].Numara == arama)
                    {
                        Console.WriteLine("isim : " + rehberListesi[i].FirstName);
                        Console.WriteLine("Soyisim : " + rehberListesi[i].LastName);
                        Console.WriteLine("Telefon Numarası : " + rehberListesi[i].Numara);
                        Console.WriteLine("-------");
                        flag = true;
                    }
                }
                if (!flag) Console.WriteLine("Aranan Kişi Bulunamadı! ");
            }
        }
        public void kisiSil(string nameOrLastName)
        {
            bool flag = false;
            for (int i = 0; i < rehberListesi.Count; i++)
            {
                if (rehberListesi[i].FirstName == nameOrLastName || rehberListesi[i].LastName == nameOrLastName)
                {
                    Console.WriteLine("Şu Kişi Silindi" + rehberListesi[i].FirstName + " " + rehberListesi[i].LastName);
                    rehberListesi.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            if (!flag) Console.WriteLine("Aranan Kişi Bulunamadı! ");
            programDursunMu();
        }
        public void kisiBilgisiGuncelle(string nameOrLastName)
        {
            bool flag = false;
            for (int i = 0; i < rehberListesi.Count; i++)
            {
                if (rehberListesi[i].FirstName == nameOrLastName || rehberListesi[i].LastName == nameOrLastName)
                {
                    Console.WriteLine("Lütfen değiştirmek istediğiniz isimi giriniz: ");
                    string name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Lütfen değiştirmek istediğiniz soyisimi giriniz: ");
                    string lastName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Lütfen değiştirmek istediğiniz numarayi giriniz: ");
                    int numara = int.Parse(Console.ReadLine());
                    rehberListesi[i].FirstName = name;
                    rehberListesi[i].LastName = lastName;
                    rehberListesi[i].Numara = numara;
                    flag = true;
                    break;
                }
            }
            if (!flag) Console.WriteLine("Aranan Kişi Bulunamadı! ");
        }
        public void programDursunMu()
        {
            Console.WriteLine("Devam etmek istiyor musunuz ");
            Console.WriteLine("(1)Evet ");
            Console.WriteLine("(2)Hayır ");
            int temp = int.Parse(Console.ReadLine());
            if (temp == 1)
                ChoseList();
            else
                Environment.Exit(0);
        }
    }
}