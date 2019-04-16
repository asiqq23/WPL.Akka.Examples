namespace WPL.AkkaNet.IotApp.Tests
{
    using Akka.Actor;
    using FluentAssertions;
    using Xunit;

    public class DeviceTests
    {
        [Fact]
        public void Device_actor_must_reply_with_empty_reading_if_no_temperature_is_known()
        {
            var system = ActorSystem.Create("iot-system");

            //var testProbe = CreateTestProbe();

            //var probe = testProbe.CreateTestProbe(system);
            //var deviceActor = system.ActorOf(Device.Props("group", "device"));

            //deviceActor.Tell(new ReadTemperature(requestId: 42), probe.Ref);
            //var response = probe.ExpectMsg<RespondTemperature>();

            //response.RequestId.Should().Be(42);
            //response.Value.Should().BeNull();
        }
    }
}
