using ApiBaseProject.Models;
using ApiBaseProject.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ApiBaseProject.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _db;

    public ProductService(AppDbContext db)
    {
        _db = db;
    }


    public async Task<IEnumerable<ProductReadDto>> GetAll()
    {
        return await _db.Products
            .Select(p => new ProductReadDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            })
            .ToListAsync();
    }


    public async Task<ProductReadDto> Add(ProductCreateDto dto)
    {
        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price
        };

        await _db.Products.AddAsync(product);
        await _db.SaveChangesAsync();

        return new ProductReadDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        };
    }
}
