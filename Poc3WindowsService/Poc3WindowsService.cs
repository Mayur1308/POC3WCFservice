using System.ServiceProcess;


namespace Poc3WindowsService
{
    public partial class Poc3WindowsService : ServiceBase
    {
        public Poc3WindowsService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
        }
        protected override void OnStop()
        {
        }
    }
}
