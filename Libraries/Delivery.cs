namespace Libraries;

internal abstract class Delivery
{
   protected internal abstract string Address { get; set; }
}

internal class HomeDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

internal class PickPointDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

internal class ShopDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
