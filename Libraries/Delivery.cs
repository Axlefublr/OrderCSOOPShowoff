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
   internal HomeAddress Address { get; private set; }
   
   internal HomeDelivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan, HomeAddress address) : base(arrivalTime, departingTime, userPlan) {
      Address = address;
   }
}

public class PickPointDelivery : Delivery
{
   internal PickPointAddress Address { get; private set; }
   internal PickPointDelivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan, PickPointAddress address) : base(arrivalTime, departingTime, userPlan) {
      Address = address;
   }
}

public class ShopDelivery : Delivery
{
   internal ShopAddress Address { get; private set; }
   internal ShopDelivery(DateTime arrivalTime, DateTime departingTime, UserPlan userPlan, ShopAddress address) : base(arrivalTime, departingTime, userPlan) {
      Address = address;
   }
}
