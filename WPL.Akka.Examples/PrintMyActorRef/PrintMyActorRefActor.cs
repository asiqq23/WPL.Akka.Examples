using System;
using Akka.Actor;

namespace WPL.AkkaNet.Examples.PrintMyActorRef
{
    public class PrintMyActorRefActor : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case "printit":
                    IActorRef secondRef = Context.ActorOf(Props.Empty, "second-actor");
                    Console.WriteLine($"Second: {secondRef}, thread: {Environment.CurrentManagedThreadId}");
                    break;
            }
        }
    }
}