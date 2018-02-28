using System;
using Akka.Actor;

namespace WPL.AkkaNet.Examples.SupervisionActors
{
    public class SupervisedActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case "fail":
                    Console.WriteLine("supervised actor fails now");
                    throw new Exception("I've failed");
            }
        }

        protected override void PreStart() => Console.WriteLine("Actor started");
        protected override void PostStop() => Console.WriteLine("Actor stopped");
    }
}