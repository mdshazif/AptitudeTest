using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
            });
            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();
        }
    }

    class Alexa
    {
        public Information info = null; public Alexa() { info = new Information() { GreetingMessage = "Hello, I am Alexa" }; }
        public void Configure(Action<Information> lambda)
        {
            lambda(info);
        }
        public string Talk() { return info.GreetingMessage; }
    }
    class Information
    {
        private string ownerName = string.Empty; private string greetingMsg = string.Empty;
        public string OwnerName { get { return ownerName; } set { ownerName = value; } }
        public string GreetingMessage
        {
            get { return this.greetingMsg.Replace("{OwnerName}", this.OwnerName); }
            set { this.greetingMsg = value; }
        }
    }

}
