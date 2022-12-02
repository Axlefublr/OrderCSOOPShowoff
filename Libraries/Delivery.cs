namespace Libraries;

internal abstract class Delivery
{
}

internal class HomeDelivery : Delivery
{
   internal HomeAddress Address { get; set; }
}

internal class PickPointDelivery : Delivery
{
   internal PickPointAddress Address { get; set; }
}

internal class ShopDelivery : Delivery
{
   internal ShopDelivery Address { get; set; }
}
