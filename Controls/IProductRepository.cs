using StatybaServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatybaServer.Controls
{
    public interface IProductRepository
    {
        IEnumerable<Preke> GetPrekes(string filter);
        Preke GetPreke(int id);

        public void AddPreke(Preke preke);

        public void UpdatePreke(Preke preke);

        public void DeletePreke(int id);
    }
}
