using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne.Tabanli.ProgramlamaHafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı üretmek istiyorsunuz?\n");
            int adet = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÜretilecek sayılar kaçtan başlasın :\n ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nÜretilecek sayılar kaçta bitsin : \n");
            int bitis = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];
            Random rnd = new Random();
            int i = 0;
            while (i < adet)
            {
                int sayi = rnd.Next(baslangic,bitis);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi;
                i++;
            }

            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
                Console.WriteLine("\n"+sayi);


            Console.ReadKey();
        }
    }
}
