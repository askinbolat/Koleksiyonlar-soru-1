using System;
using System.Collections;
/*
Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
(ArrayList sınıfını kullanarak yazınız.)
-Negatif ve numeric olmayan girişleri engelleyin.
-Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
-Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

namespace Koleksiyonlar_soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalsayi = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            
            for (int k = 0; k < 20; k++)
            {
                Console.Write("{0}. sayıyı giriniz:",k+1);
                int deger=Convert.ToInt32(Console.ReadLine());
            
                if (deger<0)
                {
                    Console.WriteLine("Geçersiz sayı girdiniz.");
                    break;
                }        
                else
                {
                    int kontrol=0;
                    for (int i = 2; i < deger; i++)
                    {
                        if (deger % i ==0)
                        {
                        kontrol=1;
                        break;
                        }
                    }
                    if (kontrol==1)
                    {
                        asalOlmayan.Add(deger);
                    }
                    else
                    {
                        asalsayi.Add(deger);
                    }
                }
            }

            
            asalsayi.Sort();
            asalOlmayan.Sort();
            asalsayi.Reverse();
            asalOlmayan.Reverse();

            Console.WriteLine("Asal sayılar:");
            foreach (var item in asalsayi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Asal olmayan sayılar:");
            foreach (var item in asalOlmayan)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Asal sayı adeti:" +asalsayi.Count);

            int toplam=0;
            for (int i = 0; i < asalsayi.Count; i++)
            {
                toplam+=(int)asalsayi[i];
            }
            
            float asalOrtalama= toplam/asalsayi.Count;
            Console.WriteLine("Asal sayıların ortalaması:" +asalOrtalama);
            

            Console.WriteLine("Asal olmayan sayı adeti:" +asalOlmayan.Count);

            int toplam2=0;
            for (int i = 0; i < asalOlmayan.Count; i++)
            {
                toplam2+=(int)asalOlmayan[i];
            }
            
            float asalOlmayanOrtalama= toplam2/asalOlmayan.Count;
            Console.WriteLine("Asal olmayan sayıların ortalaması:" +asalOlmayanOrtalama);
        }        
             
    }
}      
   
                
    
            

