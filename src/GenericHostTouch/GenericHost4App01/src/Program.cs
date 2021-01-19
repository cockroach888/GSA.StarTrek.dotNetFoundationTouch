using GenericHost4Lib01;
using System;
using System.Threading.Tasks;

namespace GenericHost4App01
{
    class Program
    {
        [STAThread]
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            await new GenericHostSample().Run(args);
        }
    }
}
