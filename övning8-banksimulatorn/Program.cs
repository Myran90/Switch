using System;

namespace övning8_banksimulatorn
{
   class Program
    {
        static void Main(string[] args)
        {
            int saldo = 0;

            while (true)
            {
            Console.Clear();
            Console.WriteLine("Banksimulatorn");
            Console.WriteLine("[1] Sätt in pengar");
            Console.WriteLine("[2] Ta ut pengar");
            Console.WriteLine("Nuvarande Saldo: " + saldo);

            int val = Convert.ToInt32(Console.ReadLine());

                switch (val)
                {
                    case 1:
                    Console.Write("Hur mycket vill du sätta in? ");
                    int insättning = Convert.ToInt32(Console.ReadLine());
                    saldo += insättning;
                    break;
                    
                    case 2:
                    Console.Write("Hur mycket pengar vill du ta ut? ");
                    int uttag = Convert.ToInt32(Console.ReadLine());
                    saldo -= uttag;
                    break;

                    case 3:
                    Console.Write("Ditt saldo är: "+ saldo);
                    break;
                }   
        }
    }
    }
}
