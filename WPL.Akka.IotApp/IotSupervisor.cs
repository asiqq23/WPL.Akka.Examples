namespace WPL.AkkaNet.IotApp
{
    using Akka.Actor;
    using Akka.Event;

    public class IotSupervisor : UntypedActor
    {
        public ILoggingAdapter Log { get; } = Context.GetLogger();

        protected override void OnReceive(object message)
        {

        }

        protected override void PreStart() => Log.Info("IoT app started");
        protected override void PostStop() => Log.Info("IoT app stopped");

        public static Props Props() => Akka.Actor.Props.Create<IotSupervisor>();
    }
}