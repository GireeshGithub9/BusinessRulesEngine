using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class UpgradeMembershipHandler : OrderProcessor
    {
        //Handles Upgrade membership Orders
        public override RuleResponse processOrder(OrderDetails order)
        {
            RuleResponse ruleResponse = new RuleResponse();
            Console.WriteLine("Upgrade membership handler");
            FileStream tmpFile = null;
            try
            {
                tmpFile = File.Create("test");
            }
            catch (IOException e)
            {
                throw new Exception(e.Message);
            }
            sendEmail(order.UserEmail, "Welcome to ABC company", "New Member Body", tmpFile);
            ruleResponse.UpgradeMembership = true;
            return ruleResponse;
        }

    }
}
