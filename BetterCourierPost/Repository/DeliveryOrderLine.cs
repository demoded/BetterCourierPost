using System;
using System.Collections.Generic;
using System.Text;
using BetterCourierPost.Repository.Interfaces;

namespace BetterCourierPost.Repository
{
    internal class DeliveryOrderLine
    {
        public double lineNumber { get; set; }
        public IDeliveryItem item { get; set; }
    }
}
