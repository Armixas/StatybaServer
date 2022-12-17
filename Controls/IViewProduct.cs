using StatybaServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatybaServer.Controls
{
    public interface IViewProduct
    {
        Preke Execute(int id);
    }
}
