using ApiBaseProject.Models;
using ApiBaseProject.Dtos;

namespace ApiBaseProject.Services;

public interface IProductService
{
    Task<IEnumerable<ProductReadDto>> GetAll();
    Task<ProductReadDto> Add(ProductCreateDto dto);
}
