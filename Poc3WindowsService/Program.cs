using System.ServiceProcess;

namespace Poc3WindowsService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Poc3WindowsService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
