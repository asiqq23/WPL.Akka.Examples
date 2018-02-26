using System;
using Akka.Actor;
using Akka.Event;
using Akka.Pattern;
using WPL.Akka.Examples.PrintMyActorRef;
using WPL.Akka.Examples.StartStopActor;

namespace WPL.Akka.Examples
{
    public class IotApp
    {
        public static void Init()
        {
            //PrintMyActorRefInit.Init();
            //StartStopActorsInit.Init();
            SupervisionActors.SupervisionActors.Init();
        }
    }

    
}