using System.Linq;

internal class Program
{

    private static void Main(string[] args)
    {
        //Ekrandan girilen kolon sayısı kadar 6 adet sayı üreten ve ürettiği sayıları sıralayarak ekrana yazıdırın.Rastgele sayı üretilirken aynı rakam denk gelirse tekrar sayı üretmeli.1-91 arasında rakamlardan oluşacak kolonlar.

        Random rnd = new Random();
        int kolonSayisi, rastgeleSayi, rastgeleSayi1;
        int[] sayilar = new int[6];
        int[] kazananSayilar = new int[6];
        Console.Write("Kaç kolon oynamak istersiniz? ");
        kolonSayisi = Convert.ToInt32(Console.ReadLine());

        for (int j = 1; j <= kolonSayisi; j++)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                rastgeleSayi = rnd.Next(1, 91);
                if (!sayilar.Contains(rastgeleSayi))
                {
                    sayilar[i] = rastgeleSayi;
                }
                else i--;
            }
            Array.Sort(sayilar);
            Console.Write(j+") ");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi +" ");
            }
            Console.WriteLine("\n");
        }


        for (int k = 0; k < kazananSayilar.Length; k++)
        {
            rastgeleSayi1 = rnd.Next(1,91);
            if(!kazananSayilar.Contains(rastgeleSayi1))
            {
                kazananSayilar[k] = rastgeleSayi1;
            }
            else
            {
                k--;
            }
        }
        Array.Sort(kazananSayilar);
        Console.Write("Kazanan Sayılar: ");
        foreach (int item in kazananSayilar)
        {
            Console.Write(item+" ");
        }



    }



}