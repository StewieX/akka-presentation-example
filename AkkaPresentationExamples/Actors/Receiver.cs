using Akka.Actor;
using AkkaPresentationExamples.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkkaPresentationExamples.Actors
{
  public class Receiver : ReceiveActor
  {    
    public Receiver(){

      Receive<ExampleMessage>(message =>
      {
        Console.WriteLine("Receiver received: \"" + message.Content + "\"");
      });
    }
  }
}
