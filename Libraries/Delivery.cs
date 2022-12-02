namespace Libraries;

internal abstract class Delivery
{
   internal abstract Address Address { get; set; }
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
