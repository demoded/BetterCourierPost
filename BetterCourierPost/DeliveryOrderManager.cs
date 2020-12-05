using BetterCourierPost.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost
{
    public class DeliveryOrderManager
    {
        private DeliveryOrder _deliveryOrder;
        private DeliveryOrderManager()
        {
            _deliveryOrder = new DeliveryOrder();
        }

        public static DeliveryOrderManager CreateDeliveryOrder()
        {
            return new DeliveryOrderManager();
        }

        public DeliveryOrderManager AddParcel()
        {
            _deliveryOrder.addItem(new Parcel());

            return this;
        }

        public Decimal GetPrice()
        {
            return _deliveryOrder.Amount;
        }
    }
}
