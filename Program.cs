using BusinessRulesEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngineClient
{
    class Program
    {

        /*Procesing Business orders 
         * Users can supply command line arguments 
         * --email girish@gmail.com --order-type Book --agent Gireesh
         * based on the order type application will process 
         */
        static void Main(string[] args)
        {
            if (!(args.Length == 4 || args.Length == 6))
            {
                Console.WriteLine("Invalid arguments");
                return;
            }
            OrderDetails order = new OrderDetails();
            try
            {
                for (int i = 0; i < args.Length; i += 2)
                {
                    if (args[i].Equals("--email", StringComparison.OrdinalIgnoreCase))
                    {
                        order.UserEmail = args[i + 1];
                    }
                    else if (args[i].Equals("--order-type", StringComparison.OrdinalIgnoreCase))
                    {
                        string ordertype = args[i + 1].ToUpper();
                        OrderType myOrdtype;
                        Enum.TryParse(ordertype, out myOrdtype);
                        order.OrderType = myOrdtype;
                    }
                    else if (args[i].Equals("--agent", StringComparison.OrdinalIgnoreCase))
                    {
                        order.AgentContact = args[i + 1];
                    }
                    else
                    {
                        Console.WriteLine("Invalid arguments");
                        return;
                    }
                }
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Unsupported Order Type %s\r\n", args[3]);
            }
            new HandleOrder().handleOrder(order);
            Console.ReadKey();
        }
    }
}
