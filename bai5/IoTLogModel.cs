using System;

namespace bai5
{
    public class IoTLogModel
    {
        public string Timestamp { get; set; } = string.Empty;
        public double Temperature { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}