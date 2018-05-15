using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActorSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorSystem
                .Create("MyActorSystem")
                .Terminate()
                .Wait();
        }


    }
}
