using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using HelloWorldClient.HelloWorldService;
namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new HelloWordServiceRefference.HelloWorldClient();
            string s = p.GetMessage("no");
            Console.WriteLine(s);
            Console.Read();

        }
    }
}
