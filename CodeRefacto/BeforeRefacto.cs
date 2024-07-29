using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefacto
{
    public class BeforeRefacto
    {
        public void Process(Order? order)
        {
            if (order != null)
            {
                if (order.IsVerified)
                {
                    if (order.Items.Count > 0)
                    {
                        if (order.Items.Count > 15)
                        {
                            throw new Exception("The order " + order.Id + " has too many items");
                        }
                        if (order.Status != "ReadyToProcess")
                        {
                            throw new Exception("The order " + order.Id + " isn't ready to process");
                        }
                        order.IsProcessed = true;
                    }
                }
            }
        }

    }
}
