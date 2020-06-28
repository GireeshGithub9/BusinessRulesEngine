using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class LearnToSkiHandler : OrderProcessor
    {
        //Handles LearnToSki Orders
        public override RuleResponse processOrder(OrderDetails order)
        {
            RuleResponse ruleResponse = new RuleResponse();
            Console.WriteLine("LearnToSkiHandler");
            ruleResponse.LearnToSki = true;
            return ruleResponse;
        }

    }
}
