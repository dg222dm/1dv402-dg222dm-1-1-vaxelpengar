using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Växelpengar___Nivå_A
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int keepTheChange;
            uint total;
            double roundingOffAmount;
           
            
            double subTotal = 0;
            int moneyReceived = 0;

            //Hantera inmatning av kostnad på produkt.
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma     : ");
                    subTotal = double.Parse(Console.ReadLine());
                    total = (uint)Math.Round(subTotal);
                    break;

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL totalsumma felaktig.");
                    Console.ResetColor();
                }
            }
            if (total < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }
            
            //Hantera inmatning av erhållet belopp.
            while(true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    moneyReceived = int.Parse(Console.ReadLine());
                    break;

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL erhållet belopp felaktig.");
                    Console.ResetColor();
                }

               
            }

            //Avrundning av totalsumma.
            //total = (uint)Math.Round(subTotal);

            if (total > moneyReceived)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }
            //Beräknar hur stor avrundning.
            roundingOffAmount = total - subTotal;

            //Beräknar hur mycket användaren ska få tillbaks efter köp
            keepTheChange = moneyReceived - (int)total;

           
            
            //Utskrift av Kvitto
            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Totalt               : {0,26:C}", subTotal);
            Console.WriteLine("Öresavrundning       : {0,26:C}", roundingOffAmount);
            Console.WriteLine("Att betala           : {0,26:C0}", total);
            Console.WriteLine("Kontant              : {0,26:C0}", moneyReceived);
            Console.WriteLine("Tillbaka             : {0,26:C0}", keepTheChange);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");

            //Växel hantering
           
            if (keepTheChange >= 500)
            {
                Console.WriteLine("500-lappar     : {0}", keepTheChange / 500);
                keepTheChange %= 500;
            }

            if (keepTheChange >= 100)
            {
                Console.WriteLine("100-lappar     : {0}", keepTheChange / 100);
                keepTheChange %= 100;
            }
            
            if (keepTheChange >= 50)
            {
                Console.WriteLine("50-lappar      : {0}", keepTheChange / 50);
                keepTheChange %= 50;
            }

            if (keepTheChange >= 20)
            {
                Console.WriteLine("20-lappar      : {0}", keepTheChange / 20);
                keepTheChange %= 20;
            }

            if (keepTheChange >= 10)
            {
                Console.WriteLine("10-kronor      : {0}", keepTheChange / 10);
                keepTheChange %= 10;
            }

            if (keepTheChange >= 5)
            {
                Console.WriteLine("5-kronor       : {0}", keepTheChange / 5);
                keepTheChange %= 5;
            }

            if (keepTheChange >= 1)
            {
                Console.WriteLine("1-kronor       : {0}", keepTheChange / 1);
                keepTheChange %= 1;
            }

        }
    }
}
