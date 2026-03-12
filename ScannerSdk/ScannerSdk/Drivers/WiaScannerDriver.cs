using WIA;
using ScannerSDK.Interfaces;
using ScannerSDK.Models;

namespace ScannerSDK.Drivers
{
    public class WiaScannerDriver : IScannerDriver
    {
        public List<string> GetDevices()
        {
            List<string> devices = new List<string>();

            DeviceManager manager = new DeviceManager();
          

            // الاجهزة المتصلة
            foreach (DeviceInfo deviceInfo in manager.DeviceInfos)
            {
                try
                {
                    // حاول الاتصال بالجهاز
                    Device device = deviceInfo.Connect();
                    if (device != null)
                    {
                        devices.Add(device.Properties["Name"].get_Value().ToString());
                    }
                }
                catch
                {
                    // إذا لم يتم الاتصال، نتجاهل الجهاز
                    continue;
                }
            }

            return devices;
        }

        public byte[] Scan(ScanOptions options)
        {
            DeviceManager manager = new DeviceManager();

            DeviceInfo deviceInfo = manager.DeviceInfos[1];

            Device device = deviceInfo.Connect();

            Item item = device.Items[1];
            //code  GUID  خاص بي JPEG Format
            ImageFile image = (ImageFile)item.Transfer("{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}");

            return (byte[])image.FileData.get_BinaryData();
        }
    }
}