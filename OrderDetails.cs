using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    //user input details
    public class OrderDetails
    {
        public string UserEmail { get; set; }
        public string AgentContact { get; set; }
        public OrderType OrderType { get; set; }
    }
}
