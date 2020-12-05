using BetterCourierPost.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost.Repository
{
    public class DeliveryOrder
    {
        List<DeliveryOrderLine> orderLines = new List<DeliveryOrderLine>();
        public decimal Amount { get; } = 0;
        public bool isPriced { get; set; } = false;

        public DeliveryOrder()
        {
            orderLines = new List<DeliveryOrderLine>();
        }

        internal void addItem(IDeliveryItem deliveryItem)
        {
            var line = new DeliveryOrderLine();
            line.lineNumber = 1;
            line.item = deliveryItem;
            orderLines.Add(line);
        }

        internal List<DeliveryOrderLine> getOrderLines()
        {
            return orderLines;
        }
    }
}
