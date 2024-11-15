using Microsoft.EntityFrameworkCore;
using Project_Ecommerce_api.Data;
using Project_Ecommerce_api.IServices;
using Project_Ecommerce_api.Models;

namespace Project_Ecommerce_api.Services
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;

        public BrandService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            return await _context.Brands.FindAsync(id);
        }

        public async Task<Brand> CreateBrandAsync(Brand brand)
        {
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return brand;
        }

        public async Task<Brand> UpdateBrandAsync(int id, Brand brand)
        {
            var currentBrand = await _context.Brands.FindAsync(id);
            if (currentBrand == null)
            {
                return null;
            }
            currentBrand.BrandName = brand.BrandName;
            currentBrand.BrandDescription = brand.BrandDescription;
            await _context.SaveChangesAsync();
            return currentBrand;
        }

        public async Task<bool> DeleteBrandAsync(int id)
        {
            var currentBrand = await _context.Brands.FindAsync(id);
            if (currentBrand == null)
            {
                return false;
            }
            _context.Brands.Remove(currentBrand);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
