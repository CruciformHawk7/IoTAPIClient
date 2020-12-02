using IoTAPIClient.Models;

namespace IoTAPIClient.Models {
    public class Device {
        public string ID {get; set;}
        public string Friendly {get; set;}
        public string IP {get; set;}
        public DeviceTypes DeviceType {get; set;}
    }
}