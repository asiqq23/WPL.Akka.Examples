using Akka.Actor;
using System;
using System.Threading.Tasks;

namespace WPL.AkkaNet.Examples.SupervisionActors
{
    public class MyActor : ReceiveActor
    {
        public MyActor()
        {
            ReceiveAsync<string>(async _ =>
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                Sender.Tell("done");
            });
        }
    }

}