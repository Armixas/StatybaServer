using StatybaServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatybaServer.Controls
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Preke> Execute(string filter)
        {
            return productRepository.GetPrekes(filter);
        }
    }
}
