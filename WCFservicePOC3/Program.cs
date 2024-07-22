using Poc3WindowsService;
using System.ServiceModel;
using System.ServiceProcess;

namespace WCFservicePOC3
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WCFServiceReference.Service1Client service1 = new WCFServiceReference.Service1Client();

            if (CheckService("Poc3WindowsService"))
            {
                service1.CreateStringKey("Poc3String", "Added");
                service1.CreateDwordKey("IsInstalled", 0);
                service1.ModifyStringKey("Poc3String", "WCF");
                service1.ModifyDwordKey("IsInstalled", 1);
                service1.DeleteKey("Poc3String");
                service1.DeleteKey("IsInstalled");
            }
        }

        public static bool CheckService(string ServiceName)
        {
            var services = ServiceController.GetServices();
            string serviceStatus = string.Empty;
            bool isServiceStart = false;

            foreach (var s in services)
            {
                if (s.ServiceName == ServiceName)
                {
                    serviceStatus = s.Status.ToString();
                    if (serviceStatus.Equals("Running"))
                    {
                        isServiceStart = true;
                    }
                }
            }
            return isServiceStart;
        }
    }
}
