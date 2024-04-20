using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal_modul_08_1302223110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig config = new BankTransferConfig();

            config.Lang();
            int tf = int.Parse(Console.ReadLine());

            config.transferDana(tf);

            config.pilihMetode();

            config.check();

            Console.ReadLine();

            config.switchLang();

            config.Lang();
            int tf2 = int.Parse(Console.ReadLine());

            config.transferDana(tf2);

            config.pilihMetode();

            config.check();

            Console.ReadLine();
        }
    }
}
