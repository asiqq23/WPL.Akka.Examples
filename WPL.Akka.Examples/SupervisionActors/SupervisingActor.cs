using Akka.Actor;

namespace WPL.Akka.Examples.SupervisionActors
{
    public class SupervisingActor : UntypedActor
    {
        private IActorRef supervisedActor = Context.ActorOf(Props.Create<SupervisedActor>(), "supervides");

        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case "failChild":

                    supervisedActor.Tell("fail");
                    break;
            }
        }
    }
}