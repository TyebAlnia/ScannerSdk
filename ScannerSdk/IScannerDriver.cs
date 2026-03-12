using ScannerSDK.Models;
namespace ScannerSDK.Interfaces
{
    public interface IScannerDriver
    {
        List<string> GetDevices();

        byte[] Scan(ScanOptions options);
    }
}
