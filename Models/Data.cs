using System;
namespace IoTAPIClient.Models {
    public class Data {
        public DateTime Time {get; set;}
        public double TotalUsage {get; set;}
        public double TotalProduction {get; set;}
        public int BatteryLevel {get; set;}
        public DeviceMeasure[] Measures {get; set;}
    }
}