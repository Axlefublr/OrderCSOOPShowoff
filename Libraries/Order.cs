namespace Libraries;

public class Order<TDelivery, Tid>
   where TDelivery : Delivery
   where Tid : notnull
{
   public TDelivery Delivery { get; set; } //User can change their delivery specifics after creating the order

   public Tid Id
   {
      get { return Id; }
      private set { } //Once you create an order, there's no situation where you'd change the id
   }

   public string Description { get; set; } //Description of the order can change as well, without needing to create another separate order

   private List<Product<Tid>> AddedItems = default;
   public Product<Tid> this[int product]
   {
      get
      {
         return AddedItems[product];
      }
   }

   public void AddProduct(Product<Tid> product)
   {
      if (product is not null)
         AddedItems.Add(product);
   }

   public void RemoveProduct(Product<Tid> product)
   {
      if (product is not null)
         AddedItems.Remove(product);
   }

   public Order(TDelivery delivery, Tid id, string description)
   {
      Delivery = delivery;
      Id = id;
      Description = description;
   }

   public Order(TDelivery delivery, Tid id, string description, params Product<Tid>[] products) : this(delivery, id, description)
   {
      foreach (Product<Tid> product in products)
      {
         AddedItems.Add(product);
      }
   }
}
