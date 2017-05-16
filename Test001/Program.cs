using NFX.ApplicationModel;
using NFX.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет это тест!");
            try
            {
                using (var app = new ServiceBaseApplication(args, null))
                using (var server = new WaveServer())
                {
                    server.Configure(null);
                    server.Start();
                    Console.WriteLine("Севрер запущен");
                    Console.ReadLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка");
                Console.WriteLine(ex);
                Environment.ExitCode = -1;
                Console.ReadLine();
            }
        }
    }
}
