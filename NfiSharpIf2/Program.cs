using System;

namespace NfiSharpIf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många paket är kvar");

            int paket = 0;
            while (true)
            {
                var s = Console.ReadLine();
                if (int.TryParse(s, out paket))
                    break;
            }
            //int paket = Convert.ToInt32(Console.ReadLine());
            if (paket < 10)
            {
                Console.WriteLine("Beställ 30 paket");
            }
            else if (paket >= 10 && paket <= 20)
            {
                Console.WriteLine("Beställ 20 paket");
            }
            else
            {
                Console.WriteLine("Du behöver inte beställa någon mjölk.");
            }
        }
    }
}
