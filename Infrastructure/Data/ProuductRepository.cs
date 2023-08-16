using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProuductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProuductRepository(StoreContext context)
        {
            _context = context;   
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
           return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}