namespace Libraries;

public abstract class Delivery
{
   protected internal abstract string Address { get; set; }
}

public class HomeDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class PickPointDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class ShopDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
