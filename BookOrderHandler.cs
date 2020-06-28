using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class BookOrderHandler : OrderProcessor
    {
        //Handles Book Orders
        public override RuleResponse processOrder(OrderDetails order)
        {
            RuleResponse ruleResponse = new RuleResponse();
            Console.WriteLine("Book Handler");
            Console.WriteLine("Comission credited " + order.AgentContact);
            ruleResponse.BookOrder = true;
            ruleResponse.ComissionCredited = true;
            return ruleResponse;

        }

    }

}
