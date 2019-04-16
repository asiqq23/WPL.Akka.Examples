namespace WPL.AkkaNet.IotApp
{
    public sealed class TemperatureRecorded
    {
        public TemperatureRecorded(long requestId)
        {
            RequestId = requestId;
        }

        public long RequestId { get; }
    }
}