using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonPremierClient
{
    class Program
    {
        static async void MaMethodeAsynchrone(string input, ServiceReference1.Service1Client client)
        {
            Console.WriteLine($"Résultat pour {input}: { await client.GetDataAsync(Convert.ToInt32(input))}");
        }

        static void Main(string[] args)
        {
            var input = "";

            var client = new ServiceReference1.Service1Client();

            do
            {
                Console.WriteLine("Entrez un nombre");

                input = Console.ReadLine();

                Task.Run(() => MaMethodeAsynchrone(input, client));

            } while (input != "100");

            client.Close();
;        }
    }
}
