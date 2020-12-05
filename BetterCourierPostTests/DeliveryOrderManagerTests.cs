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
    }
}
