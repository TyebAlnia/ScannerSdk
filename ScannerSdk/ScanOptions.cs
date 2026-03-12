using System;
namespace ScannerSDK.Models
public class ScanOptions
{
    public int DPI { get; set; } = 300;

    public bool Color { get; set; } = true;

    public string Format { get; set; } = "jpg";
}
