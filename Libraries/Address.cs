namespace Libraries;

public abstract class Address
{
   public string Country;
   public string State;
   public string City;
   public string Street;
   private int building;
   public int Building
   {
      get { return building; }
      set
      {
         if (value > 0)
         {
            building = value;
         }
      }
   }

   public Address(string country, string state, string city, string street, int building)
   {
      Country = country;
      State = state;
      City = city;
      Street = street;
      Building = building;
   }

}

public class HomeAddress : Address
{
   private int apartment;
   public int Apartment
   {
      get => apartment;
      set
      {
         if (value > 0)
            apartment = value;
      }
   }

   private int floor;
   public int Floor
   {
      get => floor;
      set
      {
         if (value > 0)
            floor = value;
      }
   }

   public HomeAddress(string country, string state, string city, string street, int building, int apartment, int floor) : base(country, state, city, street, building)
   {
      Apartment = apartment;
      Floor = floor;
   }

}

public class PickPointAddress : Address
{
   private int pickPointPavilion;
   public int PickPointPavilion
   {
      get { return pickPointPavilion; }
      set
      {
         if (value > 0)
            pickPointPavilion = value;
      }
   }

   public PickPointAddress(string country, string state, string city, string street, int building, int pickPointPavilion) : base(country, state, city, street, building)
   {
      PickPointPavilion = pickPointPavilion;
   }
}

public class ShopAddress : Address
{

   private int shopPavilion;
   public int ShopPavilion
   {
      get { return shopPavilion; }
      set
      {
         if (value > 0)
            shopPavilion = value;
      }
   }
   
   public ShopAddress(string country, string state, string city, string street, int building, int shopPavilion) : base(country, state, city, street, building)
   {
      ShopPavilion = shopPavilion;
   }
}