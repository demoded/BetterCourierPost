using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost.Repository.Interfaces
{
    interface IDeliveryItem
    {
        ItemDimension DeliveryItemType { get; set; }
    }
}
