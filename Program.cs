using System;

namespace SayıUygulaması
{
    class Program
    {
        static void Main(){
            Menu();
        }
        static void StartGame(){
            int currentvalue=0, total=0;
            while (total<100)
            {
                var number=Console.ReadLine();
                currentvalue=int.Parse(number);
                total+=currentvalue;
            }
            Console.WriteLine("Oyun bitti. Toplam: "+total);
            Menu();
        }
        static void Menu(){
            Console.WriteLine("1-OYUNA BAŞLA. 2-UYGULAMAYI KAPAT.");
            int tercih=int.Parse(Console.ReadLine());
            switch (tercih)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız. Tekrar deneyiniz.");
                    Menu();
                    break;
            }
        }
    }
}