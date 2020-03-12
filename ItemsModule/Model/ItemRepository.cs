using System.Collections.Generic;
using System.Linq;
namespace ItemsModule.Model
{
    public class ItemRepository
    {
        public List<Item> Items => new List<Item>() {
            new Item(1,"IPhone"),
               new Item(2,"Samsun"),
                  new Item(3,"Oppo")
                     
        };

        public List<Item> Get() {

            return this.Items;
        }
        public Item Get(int id) {
            return Items.Single(p => p.Id == id);
        }
    }
}
