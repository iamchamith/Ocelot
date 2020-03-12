namespace ShippingModule.Model
{
    public class Shipping
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public Shipping(int userid,int itemid)
        {
            UserId = userid;
            ItemId = itemid;
        }
    }
}
