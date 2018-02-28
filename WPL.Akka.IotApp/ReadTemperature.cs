namespace WPL.AkkaNet.IotApp
{
    public sealed class ReadTemperature
    {
        public ReadTemperature(long requestId)
        {
            RequestId = requestId;
        }

        public long RequestId { get; }
    }
}