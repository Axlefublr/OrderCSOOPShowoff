namespace Libraries;

abstract class Delivery
{
   protected internal abstract string Address { get; set; }
}

class HomeDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

class PickPointDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

class ShopDelivery : Delivery
{
   protected internal override string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

class Order<TDelivery> where TDelivery : Delivery
{
   public TDelivery Delivery
   {
      get { return Delivery; }
      private protected set { }
   }

   public int Number
   {
      get { return Number; }
      private protected set { }
   }

   public string Description
   {
      get { return Description; }
      private protected set { }
   }

   public Order(TDelivery delivery, int number, string description)
   {
      Delivery = delivery;
      Number = number;
      Description = description;
   }
}
