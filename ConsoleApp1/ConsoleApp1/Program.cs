// C# programlamada öğrecinin sınavdan aldığı nota göre harf notu belirleme.
using System;

namespace Notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int not = Int32.Parse(Console.ReadLine());
            if (not > 100)
            {
                Console.WriteLine("Lütfen geçerli not giriniz");
            }
            else if(not > 80 && not < 100) 
            {
                Console.WriteLine("Öğrencinin Harf Notu: AA");
            }
            else if(not > 60 && not < 80)
            {
                Console.WriteLine("Öğrencinin Harf Notu: BB");
            }
            else if (not > 50 && not < 60)
            {
                Console.WriteLine("Öğrencinin Harf Notu: CC");
            }
              else 
            {
                Console.WriteLine("Öğrenci başarısız");
            }
        }
    }
}