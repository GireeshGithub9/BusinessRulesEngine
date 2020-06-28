using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class NewMemebershipHandler : OrderProcessor
    {
        //Handles  NewMembership orders
        public override RuleResponse processOrder(OrderDetails order)
        {
            RuleResponse ruleResponse = new RuleResponse();
            Console.WriteLine("New membership handler");
            sendEmail(order.UserEmail, "Welcome to ABC company", "New Member Body");
            ruleResponse.NewMembership = true;
            return ruleResponse;
        }

    }
}
