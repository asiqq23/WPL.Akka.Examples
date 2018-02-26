using System;
using Akka.Actor;

namespace WPL.Akka.Examples.PrintMyActorRef
{
    public class PrintMyActorRefInit
    {
        public static void Init()
        {
            using (var system = ActorSystem.Create("iot-app"))
            {
                var firstRef = system.ActorOf(Props.Create<PrintMyActorRefActor>(), "first-actor");
                Console.WriteLine($"Frist: {firstRef}, thread: {Environment.CurrentManagedThreadId}");
                firstRef.Tell("printit", ActorRefs.NoSender);
            }
        }
    }
}