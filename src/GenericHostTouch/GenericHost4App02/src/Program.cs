using GenericHost4Lib01;
using System;
using System.Threading.Tasks;

namespace GenericHost4App02
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            await new GenericHostSample().Run(args);
        }
    }
}
