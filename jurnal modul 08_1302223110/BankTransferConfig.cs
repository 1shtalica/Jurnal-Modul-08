using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace jurnal_modul_08_1302223110
{
    internal class BankTransferConfig
    {
        public String bahasa { get; set; }
        public int transfer {  get; set; }
        public String metode { get; set; }
        public String konfirmasi { get; set; }

        public void readJSON()
        {
            String fileJSON = File.ReadAllText(@"E:\\Programming\\Project\\Kuliah\\KPL\\Jurnal Mod 08\\Jurnal MOD 08_1302223110\\jurnal modul 08_1302223110\\bank_transfer_config.json");
            BankTransferConfig bankConfig = JsonConvert.DeserializeObject<BankTransferConfig>(fileJSON);
        }

        public void Lang()
        {
            if (bahasa == "en")
            {
                Console.Write("Please insert the amount of money to transfer: ");
            } else
            {
                Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
            }
        }

        public void switchLang()
        {
            if (bahasa == "en")
            {
                bahasa = "id";
            } else
            {
                bahasa = "en";
            }
        }

        public int transferDana(int transfer)
        {
            int biaya;
            int total;
            if (transfer <= 25000000)
            {
                biaya = 6500;
                total = transfer + biaya;
                if (bahasa == "en")
                {
                    Console.WriteLine("Transfer fee = " + biaya);
                    Console.WriteLine("total ammount = " + total);
                } else
                {
                    Console.WriteLine("Biaya transfer = " + biaya);
                    Console.WriteLine("Total biaya = " + total);
                }
                return total;
            } else
            {
                biaya = 15000;
                total = transfer + biaya;
                if (bahasa == "en")
                {
                    Console.WriteLine("Transfer fee = " + biaya);
                    Console.WriteLine("total ammount = " + total);
                }
                else
                {
                    Console.WriteLine("Biaya transfer = " + biaya);
                    Console.WriteLine("Total biaya = " + total);
                }
                return total;
            }
        }
        public String pilihMetode()
        {
            Console.WriteLine("1. RTO (real-time)");
            Console.WriteLine("2. SKN");
            Console.WriteLine("3. RTGS");
            Console.WriteLine("4. BI FAST");
            Console.WriteLine("");

            if (bahasa == "en")
            {
                Console.Write("Select transfer method: ");
            }
            else
            {
                Console.Write("Pilih metode transfer: ");
            }

            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan ==1)
            {
                return "RTO (real-time)";
            } else if (pilihan == 2)
            {
                return "SKN";
            } else if (pilihan == 3)
            {
                return "RTGS";
            } else if (pilihan == 4) {
                return "BI FAST";
            } else
            {
                if (bahasa == "en")
                {
                    return "not valid";
                }
                else
                {
                    return "tidak valid";
                }
            }
        }

        public void check()
        {
            if (bahasa == "en")
            {
                Console.Write("Please type yes to confirm the transaction: ");
                String input = Console.ReadLine();

                if (input == "yes")
                {
                    Console.WriteLine("The transfer is completed");
                } else
                {
                    Console.WriteLine("Transfer cancelled");
                }
            }
            else
            {
                Console.Write("Ketik ya untuk mengkonfirmasi transaksi: ");
                String input = Console.ReadLine();

                if (input == "ya")
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
        }
    }
}
