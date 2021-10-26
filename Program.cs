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
                        Choice.Option2();
                        break;
                    }
                    case 3:{
                        Console.Clear();
                        Choice.Option3();
                        break;
                    }
                    case 4:{
                        Console.Clear();
                        Choice.Option4();
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
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz:");

            // Kullanıcıyı pozitif bir sayı girmeye zorlar ve girilen sayı boyutunda bir array açar.
            uint length;
            while (!UInt32.TryParse(Console.ReadLine(), out length)){ 
                Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
            }
            uint[] my_list = new uint[length];

            Console.WriteLine("Lütfen " + length + " tane pozitif tam sayı giriniz:");

            // Her bir pozitif sayı elemanını atamak için bir loop, istenilen dışında bir veri girilir ise tekrar kaldığı yerden tekrar ister.
            uint element;
            for (int i = 0; i < length; i++)
            {
                while (!UInt32.TryParse(Console.ReadLine(), out element)){
                    Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
                }
                my_list[i] = element;
            }
            
            // Girilen pozitif sayıları doğrusal bir formatta sıralar.
            Console.WriteLine("\nGirmiş olduğunuz çift tam sayılar");
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


        public void Option2()
        {
            Console.WriteLine("Lütfen 2 pozitif tam sayı giriniz:");

            // n ve m değerlerini alır
            uint input_n;
            while (!UInt32.TryParse(Console.ReadLine(), out input_n)){ 
                Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
            }
            uint input_m;
            while (!UInt32.TryParse(Console.ReadLine(), out input_m)){ 
                Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
            }

            Console.Clear();
            Console.WriteLine("Lütfen " + input_n + " tane pozitif tam sayı giriniz:");
            // alınan n değeri kadar uzun boş bir array açıp kullanıcıdan pozitif tam sayılarla doldurmasını ister
            uint[] my_list = new uint[input_n];
            uint element;
            for (int i = 0; i < input_n; i++)
            {
                while (!UInt32.TryParse(Console.ReadLine(), out element)){
                    Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
                }
                my_list[i] = element;
            }

            // m ile tam bölünen elemalarını print eder
            Console.WriteLine("\nGirmiş olduğunuz "+ input_m + " ile bölünebilen tam sayılar");
            foreach (uint item in my_list)
            {
                if (item%input_m==0)
                    Console.Write(item + " ");       
                else
                    continue;
            }

            Console.ReadKey();
            Console.Clear();
        }


        public void Option3()
        {
            Console.WriteLine("Lütfen pozitif bir tamsayı giriniz:");

            uint input_n;
            while (!UInt32.TryParse(Console.ReadLine(), out input_n)){ 
                Console.WriteLine("Pozitif tam sayı dışında bir veri girdiniz.");
            }

            Console.WriteLine("\nLütfen " + input_n + " tane kelime giriniz:");
            string[] my_list = new string[input_n];
            string element;
            for (int i = 0; i < input_n; i++)
            {
                element = Console.ReadLine();
                my_list[i] = element;
            }
            Array.Reverse(my_list);

            Console.WriteLine("\nGirmiş olduğunuz kelimelerin tersten sıralanışı.");
            foreach (string item in my_list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();
        }


        public void Option4()
        {
            Console.WriteLine("Bir cümle giriniz.");

            string text = Console.ReadLine();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?'};
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            int word_count = 0;
            int letter_count = 0;

            foreach (string word in words)
            {
                word_count++;
                foreach (char letter in word)
                {
                    letter_count++;
                }
            }

            Console.WriteLine("\nCümlen toplamda " + word_count + " kelime ve " + letter_count + " harf içeriyor.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}