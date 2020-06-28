using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    //Base class that defines functionality and implementation for processing orders
    public abstract class OrderProcessor
    {
        //This method overridden in derived class for specific implementation
        public abstract RuleResponse processOrder(OrderDetails order);

        //Generic method not required to override
        protected void sendEmail(string emailAddress, string subject, string body)
        {
            Console.WriteLine("Email is sent");
        }

        //Generic method not required to override
        protected void sendEmail(string emailAddress, string subject, string body, FileStream attachment)
        {
            Console.WriteLine("Email sent with attachments..");
        }


    }
}
