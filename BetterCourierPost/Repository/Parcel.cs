using BetterCourierPost.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost.Repository
{
    public class Parcel : IDeliveryItem
    {
        public ItemDimension DeliveryItemType { get; set; }
        public ItemDimension DeliveryItemWieght { get; set; }

        public Parcel()
        {
            DeliveryItemType = ItemDimension.PacelType();
            DeliveryItemWieght = ItemDimension.PacelWeight();
        }
    }
}
