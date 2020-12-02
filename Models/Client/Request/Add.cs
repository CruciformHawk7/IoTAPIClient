using IoTAPIClient.Models;

namespace IoTAPIClient.Models.Client.Request {
    public class Add {
        public string HostURL {get; set;}
        public string FriendlyName {get; set;}
        public DeviceTypes DeviceType {get; set;}
    }
}