using Akka.Actor;

namespace WPL.AkkaNet.Examples.SupervisionActors
{
    public class SupervisionActors
    {
        public static void Init()
        {
            using (var system = ActorSystem.Create("iot-app"))
            {
                var actorRef = system.ActorOf(Props.Create<SupervisingActor>(), "supervising");
                actorRef.Tell("failChild");
            }
        }
    }
}