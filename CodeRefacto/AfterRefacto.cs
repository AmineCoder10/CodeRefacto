using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefacto
{
    public class AfterRefacto
    {
        public void Process(Order? order)
        {
            if (order == null) return;

            if (!order.IsVerified) return;

            if (!HasValidItems(order)) return;

            if (!IsReadyToProcess(order)) return;

            order.IsProcessed = true;
        }

        private bool HasValidItems(Order order)
        {
            if (order.Items.Count == 0) return false;

            if (order.Items.Count > 15)
            {
                throw new InvalidOperationException($"La commande {order.Id} a trop d'articles");
            }

            return true;
        }

        private bool IsReadyToProcess(Order order)
        {
            if (order.Status != "ReadyToProcess")
            {
                throw new InvalidOperationException($"La commande {order.Id} n'est pas prete a etre traitee");
            }

            return true;
        }
    }
}
