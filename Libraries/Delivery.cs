namespace Libraries;

public abstract class Delivery
{
   public readonly DateTime ArrivalTime;
   public readonly DateTime DepartingTime;
   public readonly UserPlan UserPlan;
   internal Delivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan) {
      ArrivalTime = arrivalTime;
      DepartingTime = departingTime;
      UserPlan = userPlan;
   }
}

public class HomeDelivery : Delivery
{
   public readonly HomeAddress Address;

   internal HomeDelivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan, HomeAddress address) : base(arrivalTime, departingTime, userPlan) {
      Address = address;
   }
}

public class PickPointDelivery : Delivery
{
   public readonly PickPointAddress Address;
   public PickPointDelivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan, PickPointAddress address) : base(arrivalTime, departingTime, userPlan) {
      Address = address;
   }
}

public class ShopDelivery : Delivery
{
   public readonly ShopAddress Address;
   public ShopDelivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan, ShopAddress address) : base(arrivalTime, departingTime, userPlan) {
      Address = address;
   }
}
