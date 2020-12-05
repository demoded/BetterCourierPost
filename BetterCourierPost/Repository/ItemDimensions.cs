using System;
using System.Collections.Generic;
using System.Text;

namespace BetterCourierPost.Repository
{
    public class ItemDimension
    {
        enum ItemDimensionType
        {
            ParcelType = 1,
            ParcelWeight = 2,
            ServiceType = 3
        }

        private readonly ItemDimensionType _itemDimensionType;

        private ItemDimension(ItemDimensionType itemDimensionType)
        {
            _itemDimensionType = itemDimensionType;
        }

        public static ItemDimension PacelType()
        {
            return new ItemDimension( ItemDimensionType.ParcelType );
        }

        public static ItemDimension PacelWeight()
        {
            return new ItemDimension( ItemDimensionType.ParcelWeight );
        }

        public static ItemDimension Service()
        {
            return new ItemDimension( ItemDimensionType.ServiceType );
        }
    }

}
