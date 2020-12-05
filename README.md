# BetterCourierPost
training project to mimic courier company

## Architecture overview:
### DeliveryOrderManager
*DeliveryOrderManager* control delivery order using *DeilveryOrderService*.
*DeliveryOrderManager* use *PriceService* to calculate price

### DeliveryOrderService
*DeliveryOrderService* creates and updates *DeliveryOrder*

*DeliveryOrder* has:
- unique *ID*
- list of *DeliveryOrderLines*
- *OrderAmount* calculated sum of all order lines amounts

*DeliveryOrderLine* has:
- line number
- one *DeliveryItem* that can be Parcel or Service (for charges and total order discounts) or any implementation of *IDeliveryItem*
- Qty
- list of *PriceDetails* (idea behind price details to keep all amounts that calculated on item. It'll give us a view how line amount build up)
- Amount (sum of all price details)

*DeliveryItem.Parcel*
- ItemType of Parcel
- ItemDimensionSize [Small, Mediul, Large, XL]
- ItemDimensionWeight

*deliveryItem.Service*
- ItemType of Service
- ItemDimensionService [SpeedyShipping]

### PriceService
*PriceService* receives a *DeliveryOrder* for processing and runs through all orderlines, calculating price for *DeliveryItem* on that line
*PriceService* use *PricingRules* to determine all criterias that price build from

*PricingRule*
- created for every *ItemDimension*
- PriceType [Dollar, Percent]
- PriceValue
