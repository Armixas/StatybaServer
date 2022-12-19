using StatybaServer.Models;

namespace StatybaServer.Components
{
    public interface ICart
    {
        int GetCount();
        int GetCountDistinct();
        int GetPrekeCount(int id);
        List<Preke> GetPrekes();
        List<Preke> GetDistinctPrekes();
        void Add(Preke preke);
        void AddById(int id);
        void RemoveById(int id);

    }
}
