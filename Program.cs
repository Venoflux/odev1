using System;

namespace odev1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Choice Choice = new();
            bool power = true;
            while (power)
            {
                Console.WriteLine("Çalıştırıcağınız programı seçiniz. (Çıkmak için 0 giriniz)");
                Console.WriteLine("\n1) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).\n Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.\nKullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.");
                Console.WriteLine("\n2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n,m).\nSonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.\nKullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.");
                Console.WriteLine("\n3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).\nSonrasında kullanıcıdan n adet kelime girmesi isteyin.\nKullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.");
                Console.WriteLine("\n4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.\nCümledeki toplam kelime ve harf sayısını console'a yazdırın.");

                int choice;
                while (!Int32.TryParse(Console.ReadLine(), out choice)){}

                switch (choice)
                {
                    case 0:{
                        power = false;
                        break;
                    }
                    case 1:{
                        Console.Clear();
                        Choice.Option1();
                        break;
                    }
                    case 2:{
                        Console.Clear();
                        break;
                    }
                    case 3:{
                        Console.Clear();
                        break;
                    }
                    case 4:{
                        Console.Clear();
                        break;
                    }
                    default:{
                        Console.Clear();
                        Console.WriteLine("Olan seçeneklerin dışında bir veri girdiniz.\n");
                        break;
                    }
                }
            }
        }
    }

    public class Choice
    {
        public void Option1()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
            int length;
            while (!Int32.TryParse(Console.ReadLine(), out length)){}

            try{
                uint[] my_list = new uint[length];
                uint element;
                Console.WriteLine("Lütfen " + length + " tane pozitif sayı giriniz:");

                for (int i = 0; i < length; i++)
                {
                    while (!UInt32.TryParse(Console.ReadLine(), out element)){
                        Console.WriteLine("Pozitif sayı dışında bir veri girdiniz.");
                    }
                    my_list[i] = element;
                }
                
                Console.WriteLine("\nGirmiş olduğunuz çift sayılar");
                foreach (uint item in my_list)
                {
                    if (item%2==0)
                        Console.Write(item + " ");       
                    else
                        continue;
                }
                Console.ReadKey();
                Console.Clear();
            }
            catch(Exception ex)
            {
                string errormessage = ex.Message.ToString();
                Console.Clear();
                Console.WriteLine(errormessage+"\n");
            }
        }

        public void Option2()
        {

        }
    }
}
