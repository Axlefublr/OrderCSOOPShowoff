namespace Libraries;

abstract class Delivery
{
   public string Address;
}

class HomeDelivery : Delivery
{
   
}

class PickPointDelivery : Delivery
{
   
}

class ShopDelivery : Delivery
{
   
}

class Order<TDelivery> where TDelivery : Delivery
{
   public TDelivery Delivery {
      get{ return Delivery; }
      private protected set{ }
   }

   public int Number {
      get{ return Number; }
      private protected set{ }
   }

   public string Description {
      get{ return Description; }
      private protected set{ }
   }

   public Order(TDelivery delivery, int number, string description) {

   }
}