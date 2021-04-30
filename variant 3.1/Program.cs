using System;

namespace variant_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int net;
            int procent;
            


            Console.WriteLine("vvedite kol-vo mesacev");
            int month;
            int gross=0;
            string input2 = Console.ReadLine();
            for (; ; )
            {
                if (Int32.TryParse(input2, out month))
                {
                    Console.WriteLine($"{month} mesacev");
                    
                }

                else
                {
                    Console.WriteLine("vvedite korrektniye danniye");
                    Console.ReadLine();
                }


                Console.WriteLine("vvedite gross zarplatu!");
                
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out gross))
                {
                    Console.WriteLine($"gross zarplata = {gross} ");
                    break;
                }
                else
                {
                    Console.WriteLine("vvedite korrektniye danniye");
                }
            }
                result = month * gross;
                procent = result * 23 / 100;
                net = result - procent;

            
                Console.WriteLine($"obwaya summa ravna {result};\t nalog raven {procent};\t summa posle uplati naloga ravna{net}");
                Console.ReadKey();
            
        }
    }
}
