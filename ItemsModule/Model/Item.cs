namespace ItemsModule.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } 
        public Item(int id,string name)
        {
            Id = id;
            Name = name;
            Image = $"{name}.jpg";
        }
    }
}
