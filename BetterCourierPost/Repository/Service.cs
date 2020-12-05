using BetterCourierPost.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost.Repository
{
    public class Service : IDeliveryItem
    {
        public ItemDimension DeliveryItemType { get; set; }
    }
}
