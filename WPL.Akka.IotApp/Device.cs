﻿namespace WPL.AkkaNet.IotApp
{
    using Akka.Actor;
    using Akka.Event;

    public class Device : UntypedActor
    {
        private double? _lastTemperatureReading = null;

        public string GroupId { get; }
        public string DeviceId { get; }

        private ILoggingAdapter Log => Context.GetLogger();

        public Device(string groupId, string deviceId)
        {
            GroupId = groupId;
            DeviceId = deviceId;
        }

        protected override void PreStart() => Log.Info($"Device actor {GroupId}-{DeviceId} started");
        protected override void PostStop() => Log.Info($"Device actor {GroupId}-{DeviceId} stopped");

        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case RecordTemperature rec:
                    Log.Info($"Recorded temperature reading {rec.Value} with {rec.RequestId}");
                    _lastTemperatureReading = rec.Value;
                    Sender.Tell(new TemperatureRecorded(rec.RequestId));
                    break;

                case ReadTemperature read:
                    Sender.Tell(new RespondTemperature(read.RequestId, _lastTemperatureReading));
                    break;
            }
        }

        public static Props Props(string groupId, string deviceId) =>
            Akka.Actor.Props.Create(() => new Device(groupId, deviceId));
    }
}