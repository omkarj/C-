using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Part2
{
    public class EventsExample1
    {
        public event TickHandler Tick;
        public EventArgs e = null;
        int i=0;
        public delegate void TickHandler(EventsExample1 m, EventArgs e);
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (Tick != null && i<3)
                {
                    Tick(this, e);
                    i++;
                }
                
            }
        }
    }

    public class Listener
    {
        public void Subscribe(EventsExample1 m)
        {
            m.Tick += new EventsExample1.TickHandler(HeardIt);
        }
        private void HeardIt(EventsExample1 m, EventArgs e)
        {
            System.Console.WriteLine("HEARD IT");
        }

    }
}
