using Project_Ecommerce_api.Models;

namespace Project_Ecommerce_api.IServices
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetAllBrandsAsync();
        Task<Brand> GetBrandByIdAsync(int id);
        Task<Brand> CreateBrandAsync(Brand brand);
        Task<Brand> UpdateBrandAsync(int id, Brand brand);
        Task<bool> DeleteBrandAsync(int id);

    }
}
