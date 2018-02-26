using System;
using Akka.Actor;

namespace WPL.Akka.IotApp
{
    public class IotAppInit
    {
        public static void Init()
        {
            using (var system = ActorSystem.Create("iot-system"))
            {
                var supervisor = system.ActorOf(Props.Create<IotSupervisor>(), "iot-supervisor");
            }
        }
    }
}