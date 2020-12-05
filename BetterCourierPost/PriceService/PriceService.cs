using BetterCourierPost.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost.PriceService
{
    class PriceService
    {
        private readonly DeliveryOrder _deliveryOrder;

        public PriceService(DeliveryOrder deliveryOrder)
        {
            _deliveryOrder = deliveryOrder;
        }

        public DeliveryOrder RepriceOrder()
        {
            var pricedOrder = new DeliveryOrder();
            
            return pricedOrder;
        }
    }
}
