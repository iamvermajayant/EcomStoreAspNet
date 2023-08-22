using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetProductsByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductsBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductsTypesAsync();
    }
}