using ScannerSDK.Interfaces;
using ScannerSDK.Models;
using ScannerSDK.Drivers;

namespace ScannerSDK.Managers
{
    public class ScannerManager
    {
        private IScannerDriver driver;

        public ScannerManager()
        {
            driver = new WiaScannerDriver();
        }

        public List<string> GetDevices()
        {
            return driver.GetDevices();
        }

        public byte[] Scan(ScanOptions options)
        {
            return driver.Scan(options);
        }
    }
}