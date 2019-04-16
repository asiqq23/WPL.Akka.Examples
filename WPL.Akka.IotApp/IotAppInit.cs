namespace WPL.AkkaNet.IotApp
{
    using Akka.Actor;

    public class IotAppInit
    {
        public static void Init()
        {
            using (var system = ActorSystem.Create("iot-system"))
            {
                var supervisor = system.ActorOf(Props.Create<IotSupervisor>(), "iot-supervisor");
                var supervisor2 = system.ActorOf(IotSupervisor.Props(), "iot-supervisor");
            }
        }
    }
}