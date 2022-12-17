using StatybaServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatybaServer.Controls
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository productRepository;
        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Preke Execute(int id)
        {
            return productRepository.GetPreke(id);
        }
    }
}
