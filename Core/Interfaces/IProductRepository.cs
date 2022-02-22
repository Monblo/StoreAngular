using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public class IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);

        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
