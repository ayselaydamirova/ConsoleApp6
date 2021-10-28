//using System;

//namespace ConsoleApp6 // MISAL 1.
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MetniTersCevir();
//        }
//        public static void MetniTersCevir()
//        {
//            string metin;
//            Console.WriteLine("tersten yazmaq istediyiniz metni daxil edin");
//            metin = Console.ReadLine();
//            for (int i = 0; i < metin.Length ; i++)
//            {
//                Console.Write(metin[metin.Length - i - 1]);

//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;

//namespace ConsoleApp6 // Misal 2.
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int index = 0, count = 1;
//            string input = "Sehidler olmez VETEN bolunmez!";
//            while (index <= input.Length - 1)
//            {
//                if (input[index] == ' ' || input[index] == '\n' || input[index] == '\t')
//                {
//                    count++;
//                }
//                index++;
//            }
//            Console.WriteLine("Total Words = " + count);
//            Console.ReadLine();
//        }
//    }
