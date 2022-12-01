namespace Libraries;

internal abstract class Address {
   protected string Country;
   protected string State;
   protected string City;
   protected string Street;
   protected int Building;
   public abstract string ValidAddress { get; }

   protected Address(string country, string state, string city, string street, int building)
   {
      Country  = country;
      State    = state;
      City     = city;
      Street   = street;
      Building = building;
   }

}

internal class HomeAddress : Address
{
   private int Apartment;
   private int Floor;
   public override string ValidAddress {
      get{
         return Country + " " + State + " " + City + " " + Street + " " + Building + " " + Apartment + " " + Floor;
      }
   }
   public HomeAddress(string country, string state, string city, string street, int building, int apartment, int floor) : base(country, state, city, street, building)
   {
      Apartment = apartment;
      Floor = floor;
   }

}