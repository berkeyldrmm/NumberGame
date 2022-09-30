﻿using System;

namespace SayıUygulaması
{
    class Program
    {
        static void Main(){
            Console.WriteLine("1-OYUNA BAŞLA. 2-UYGULAMAYI KAPAT.");
            Menu();
        }
        static void StartGame(){
            int currentvalue=0, total=0;
            while (total<50)
            {
                currentvalue=int.Parse(Console.ReadLine());
                total+=currentvalue;
            }
            Console.WriteLine("Oyun bitti. Toplam: "+total);
            Console.WriteLine("1-OYUNA BAŞLA. 2-UYGULAMAYI KAPAT.");
            Menu();
        }
        static void Menu(){
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