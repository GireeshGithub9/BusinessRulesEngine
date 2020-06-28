using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class HandleOrder
    {

        public RuleResponse handleOrder(OrderDetails order)
        {
            OrderProcessor orderProcessor = null;
            switch (order.OrderType)
            {
                case OrderType.PHYSICAL_PRODUCT:
                    orderProcessor = new PhysicalProductHandler();
                    break;
                case OrderType.BOOK:
                    orderProcessor = new BookOrderHandler();
                    break;
                case OrderType.NEW_MEMBERSHIP:
                    orderProcessor = new NewMemebershipHandler();
                    break;
                case OrderType.UPGRADE_MEMBERSHIP:
                    orderProcessor = new UpgradeMembershipHandler();
                    break;
                case OrderType.LEARNING_TO_SKI:
                    orderProcessor = new LearnToSkiHandler();
                    break;
            }
            return orderProcessor.processOrder(order);
        }
    }
}
