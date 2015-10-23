using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new HelloWorldServiceRefference.HelloWorldClient();
            Console.WriteLine("a");
          string a =  p.GetMessage("asd");
          Console.WriteLine(a);
            Console.Read();
        }
    }
}
