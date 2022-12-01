namespace Libraries;

public class Order<TDelivery, Tid> 
   where TDelivery : Delivery 
   where Tid : notnull
{
   public TDelivery Delivery
   {
      get { return Delivery; }
      private protected set { }
   }

   public Tid Id
   {
      get { return Id; }
      private protected set { }
   }

   public string Description
   {
      get { return Description; }
      private protected set { }
   }

   private List<Product<Tid>> AddedItems = default;
   
   public void AddProduct(Product<Tid> product) {
      if (product is not null)
         AddedItems.Add(product);
   }
   
   public void RemoveProduct(Product<Tid> product) {
      if (product is not null)
         AddedItems.Remove(product);
   }

   public Order(TDelivery delivery, Tid id, string description)
   {
      Delivery = delivery;
      Id = id;
      Description = description;
   }
   
   public Order(TDelivery delivery, Tid id, string description, params Product<Tid>[] products) : this(delivery, id, description) {
      foreach (Product<Tid> product in products) {
         AddedItems.Add(product);
      }
   }
}
