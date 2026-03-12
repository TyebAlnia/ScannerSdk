using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScannerSDK.Managers;
using ScannerSDK.Models;

namespace ScannerSdk.Aget.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScannerController : ControllerBase
    {
        private ScannerManager scanner = new ScannerManager();

        [HttpGet("devices")]
        public IActionResult GetDevices()
        {
            var devices = scanner.GetDevices();
            return Ok(devices);
        }

        [HttpGet("scan")]
        public IActionResult Scan()
        {
            var image = scanner.Scan(new ScanOptions());

            return File(image, "image/jpeg", "scan.jpg");
        }
    }
}
