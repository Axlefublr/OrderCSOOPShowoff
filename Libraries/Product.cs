namespace Libraries;

public class Product<Tid> where Tid : notnull
{
   private protected Tid Id;
   private protected string Color;
   private int amount = 1;
   private protected int Amount
   {
      get => amount;
      set
      {
         if (value >= 0)
         {
            amount = value;
         }
      }
   }

   private protected double Price;
   public double FullCost
   {
      get { return Amount * Price; }
   }

   // Amount is 1 by default
   public Product(Tid id, string color, double price)
   {
      Id = id;
      Color = color;
      Price = price;
   }
   public Product(Tid id, string color, int amount, double price) : this(id, color, price)
   {
      Amount = amount;
   }

   public static Product<Tid> operator ++(Product<Tid> a)
   {
      a.Amount++;
      return a;
   }
   public static Product<Tid> operator --(Product<Tid> a)
   {
      a.Amount--;
      return a;
   }
   public static Product<Tid> operator +(Product<Tid> a, int num)
   {
      a.Amount += num;
      return a;
   }
   public static Product<Tid> operator -(Product<Tid> a, int num)
   {
      a.Amount -= num;
      return a;
   }
}
