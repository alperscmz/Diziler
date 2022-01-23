using System;
namespace Diziler 
{
    class Program
    {
        static void Main(string[]args)
        {
         //diziler
         string[] renkler=new string[5];
         string[] hayvanlar={"kedi","köpek","kuş","fil"};

         int [] dizi;
         dizi=new int[5];

         renkler[0]="mavi";
         
         dizi[3]=10;

         Console.WriteLine(hayvanlar[0]);
         Console.WriteLine(dizi[3]);
         Console.WriteLine(renkler[0]); 
         
         //Döngülerle dizi kullanımları
         //Klavyeden girilen n tane sayının ortalaması

         Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
         int DiziUzunlugu=Convert.ToInt32(Console.ReadLine());
         int[] sayidizisi=new int[DiziUzunlugu];
         for (int i = 0; i < DiziUzunlugu; i++)
         {
             Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
             sayidizisi[i]=Convert.ToInt32(Console.ReadLine());
         }
         int toplam=0;
         foreach (var sayi in sayidizisi)
         {
             toplam=toplam+sayi;
             Console.WriteLine("Ortalama: " +toplam/DiziUzunlugu);
         }

        }
    }
}
