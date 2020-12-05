using System;
using Xunit;
using BetterCourierPost;

namespace BetterCourierPostTests
{
    public class DeliveryOrderManagerTests
    {
        [Fact]
        public void CreateEmptyOrder()
        {
            Assert.NotNull(DeliveryOrderManager.CreateDeliveryOrder());
        }

        [Fact]
        public void CreateOrderWithParcel()
        {
            var order = DeliveryOrderManager.CreateDeliveryOrder().AddParcel();
            Assert.NotNull(order);
            //TODO check that orderline has Parcel
        }

        [Fact]
        public void GetOrderPrice()
        {
            var order = DeliveryOrderManager.CreateDeliveryOrder().AddParcel();
            Assert.NotNull(order);
            Assert.Equal(10, order.GetPrice());
        }
    }
}
