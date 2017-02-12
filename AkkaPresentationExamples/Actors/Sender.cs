using Akka.Actor;
using AkkaPresentationExamples.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkkaPresentationExamples.Actors
{
  public class Sender : ReceiveActor
  {
    private IActorRef _receiver;

    public Sender(IActorRef receiver) {
      this._receiver = receiver;
      Receive<string>(str => SendMessage(str));
    }

    public void SendMessage(string message)
    {
      Console.WriteLine("Sending \"" + message + "\" to receiver");
      _receiver.Tell(new ExampleMessage(message));
    }
    
  }
}
