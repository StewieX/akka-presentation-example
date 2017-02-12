using Akka.Actor;
using AkkaPresentationExamples.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkkaPresentationExamples
{
  class Program
  {
    static void Main(string[] args)
    {
      var system = ActorSystem.Create("ExampleActorSystem");
      var receiver = system.ActorOf(Props.Create<Receiver>(), "Receiver");
      var sender = system.ActorOf(Props.Create(() => new Sender(receiver)), "Sender");

      Boolean running = true;
      while (running)
      {
        var input = Console.ReadLine();
        if (input == "end")
          running = false;
        else
        {
          sender.Tell(input);
        }
      }
      system.Terminate();
    }
  }
}
