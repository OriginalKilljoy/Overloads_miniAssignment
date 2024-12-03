using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads_miniAssignment
{
    internal class Welcome
    {
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen");
        }


        public void PrintWelcomeMessage(string compliment = "Du er snill!")
        {
            Console.WriteLine("Hei og velkommen" + compliment);
        }
    }
}
