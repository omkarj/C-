using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ClassNotification
    {
        public virtual void Notify()
        {
            Console.WriteLine("Email sent to user");
        }
    }

    class NotifyThroughSMS : ClassNotification
    {
        public override void Notify()
        {
            Console.WriteLine("SMS sent to user");
        }
    }
}
