using Microsoft.Azure.Devices.Client;
using System;
using Xunit;

namespace DeviceApp.Tests
{
    public class SetTelemetryIntervalTests
    {
        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=micke-1219.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=kOkty+axo6R4elfgh8AMwzvFphMZ0a0v5HjCBUr1odU=", TransportType.Mqtt);

        [Theory]
        [InlineData("SetTelemetryInterval", "10", 200)]
        [InlineData("SetInterval", "10", 501)]
        public void SetTelemetryInterval_ShouldChangeTheInterval(string methodName, string payload, int res)
        {
            deviceClient.SetMethodHandlerAsync("SetTelemetryInterval", SetTelemetryInterval, null).Wait();
        }
    }
}
