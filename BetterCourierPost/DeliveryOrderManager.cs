using BetterCourierPost.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost
{
    public class DeliveryOrderManager
    {
        public DeliveryOrderManager()
        {

        }

        public static DeliveryOrder CreateDeliveryOrder()
        {
            return new DeliveryOrder();
        }
    }
}
