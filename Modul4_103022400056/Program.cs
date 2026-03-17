using Modul4_103022400056;
using System;

namespace Modul4_103022400056
{ 
    public class program
    {
        static void Main(string[] args)
        { 
        kodePaket paket = new kodePaket();

        Console.WriteLine("kodePaket paket basic : " + paket.getKodePaket("Basic"));
        Console.WriteLine("kodePaket paket premium : " + paket.getKodePaket("Premium"));
        Console.WriteLine("kodePaket paket Traveler : " + paket.getKodePaket("Traveler"));

            Console.WriteLine("\n--- Mesin Kopi ---");
        MesinKopi mesin = new MesinKopi();

            mesin.PowerOn();
            mesin.StartBrew();
            mesin.FinishBrew();
            mesin.StartMaintenace();
            mesin.FinishMaintenance();
            mesin.PowerOFF();
            Console.ReadLine();
        }
    }
}
