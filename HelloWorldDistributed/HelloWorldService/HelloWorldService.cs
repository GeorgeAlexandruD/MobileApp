using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HelloWorldService : HelloWorld
    {
        public string GetMessage(string value)
        {
            return string.Format("HELLO WORLD: {0}", value);
        }

    }
}
