namespace StatybaServer.Components
{
    public class Cart : ICart
    {
        public int CartCount { get; set; }

        public int GetCount()
        {
            return CartCount;
        }
        public void Add()
        {
            CartCount++;
        }
        public Cart()
        {
            CartCount = 0;
            //CartCount++;
        }
    }
}
