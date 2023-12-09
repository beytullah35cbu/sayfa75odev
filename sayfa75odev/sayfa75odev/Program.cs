using System;

class Program
{
    static void Main()
    {
        /*
           Öyle bir program yazın ki kullanıcının klavyeden girdiği sayıları toplasın, kullanıcı klavyeden 83 girerse toplama
işlemini bitirsin ve sonucu ekrana yazsın. Sayfa 75
         */
        int toplam = 0;
        int komut;

        Console.WriteLine("Sayıları girmeye başlayın, sonlandırmak için 83'e basın");

        do
        {
            
            string girilenSayiMetin = Console.ReadLine();//metın olarak almamız gerekıyor bırden fazla deger

            if (int.TryParse(girilenSayiMetin, out komut)) //tek tek sayıya donustur ve topla
            {
              
                if (komut != 83)
                {
                    toplam += komut;
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz."); //sayıya donusturulmuyor yada sayı gırılmedı
            }

        } while (komut != 83);//83degılse don
 
        Console.WriteLine("Girilen sayıların toplamı: " + toplam);


        Console.ReadKey();
    }
}
