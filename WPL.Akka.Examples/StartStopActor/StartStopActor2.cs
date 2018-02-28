using System;
using Akka.Actor;

namespace WPL.AkkaNet.Examples.StartStopActor
{
    public class StartStopActor2 : UntypedActor
    {
        protected override void OnReceive(object message)
        {
            
        }

        protected override void PreStart() => Console.WriteLine($"second started, thread: {Environment.CurrentManagedThreadId}");
        protected override void PostStop() => Console.WriteLine($"second stopped, thread: {Environment.CurrentManagedThreadId}");
    }
}