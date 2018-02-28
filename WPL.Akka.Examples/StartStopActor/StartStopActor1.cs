using System;
using Akka.Actor;

namespace WPL.AkkaNet.Examples.StartStopActor
{
    public class StartStopActor1 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case "stop":
                {
                    Context.Stop(Self);
                    break;
                }
            }
        }

        protected override void PreStart()
        {
            Console.WriteLine($"first started, thread: {Environment.CurrentManagedThreadId}");
            Context.ActorOf(Props.Create<StartStopActor2>(), "second");
        }

        protected override void PostStop() =>
            Console.WriteLine($"first stopped, thread: {Environment.CurrentManagedThreadId}");
    }
}