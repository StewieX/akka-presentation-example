using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkkaPresentationExamples.Messages
{
  public class ExampleMessage
  {
    public string Content { get; private set; }

    public ExampleMessage(string content)
    {
      this.Content = content;
    }
  }
}
