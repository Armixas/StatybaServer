using StatybaServer.Models;

namespace StatybaServer.Components
{
    public class Cart : ICart
    {
        private List<Preke> prekes = new List<Preke>();
        private List<Preke> prekesDistinct = new List<Preke>();
        public Cart() { }

        public void Add(Preke preke)
        {
            var obj = prekes.FirstOrDefault(x => x.IdPreke == preke.IdPreke);

            prekes.Add(preke);

            prekesDistinct = prekes.GroupBy(x => x.IdPreke).Select(x => x.First()).ToList();
        }

        public int GetCount()
        {
            return prekes.Count;
        }

        public int GetCountDistinct()
        {
            return prekesDistinct.Count;
        }

        public int GetPrekeCount(int id)
        {
            return prekes.Where(x => x.IdPreke == id).Count();
        }

        public List<Preke> GetPrekes()
        {
            return prekes;
        }

        public List<Preke> GetDistinctPrekes()
        {
            return prekesDistinct;
        }

        public void AddById(int id)
        {
            var obj = prekes.FirstOrDefault(x => x.IdPreke == id);

            if(obj != null)
            {
                prekes.Add(obj);
            }
        }

        public void RemoveById(int id)
        {
            var obj = prekes.FirstOrDefault(x => x.IdPreke == id);

            int count = GetPrekeCount(id);

            if (obj != null)
            {
                prekes.Remove(obj);

                if(count == 1)
                {
                    obj = prekesDistinct.FirstOrDefault(x => x.IdPreke == id);
                    prekesDistinct.Remove(obj);
                }
            }
        }
    }
}
