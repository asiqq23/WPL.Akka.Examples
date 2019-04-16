﻿namespace WPL.AkkaNet.IotApp
{
    public sealed class RecordTemperature
    {
        public RecordTemperature(long requestId, double value)
        {
            RequestId = requestId;
            Value = value;
        }

        public long RequestId { get; }
        public double Value { get; }
    }
}