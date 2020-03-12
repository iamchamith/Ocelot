using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShippingModule.Model
{
    public class ShippingRepository
    {
        public List<Shipping> Items => new List<Shipping>() {
            new Shipping(1,1),
               new Shipping(1,2),
                  new Shipping(2,1),
                   new Shipping(2,2),
                   new Shipping(2,3)

        };

        public List<Shipping> Get()
        {

            return this.Items;
        }
        public Shipping GetByUserId(int id)
        {
            return Items.Single(p => p.UserId == id);
        }
        public Shipping GetByItemId(int id)
        {
            return Items.Single(p => p.ItemId == id);
        }
    }
}
