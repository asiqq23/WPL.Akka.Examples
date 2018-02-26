using Akka.Actor;

namespace WPL.Akka.Examples.StartStopActor
{
    public class StartStopActorsInit
    {
        public static void Init()
        {
            using (var system = ActorSystem.Create("iot-app"))
            {
                var firstStartStop = system.ActorOf(Props.Create<StartStopActor1>(), "first");
                firstStartStop.Tell("stop");
            }
        }
    }
}