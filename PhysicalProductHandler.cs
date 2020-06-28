using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class PhysicalProductHandler : OrderProcessor
    {
        //Handled Physical Product Orders
        public override RuleResponse processOrder(OrderDetails order)
        {
            RuleResponse ruleResponse = new RuleResponse();
            Console.WriteLine("Physical Product Handler");
            Console.WriteLine("Comission credited " + order.AgentContact);
            ruleResponse.ComissionCredited = true;
            ruleResponse.EmailSent = true;
            return ruleResponse;
        }

    }
}
