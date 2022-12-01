namespace Libraries;

internal abstract class Address {
   protected string Country;
   protected string State;
   protected string City;
   protected string Street;
   protected int Building;

   protected void CreateAddress(string country, string state, string city, string street, int building)
   {
      Country  = country;
      State    = state;
      City     = city;
      Street   = street;
      Building = building;
   }
}