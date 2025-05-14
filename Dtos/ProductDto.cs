namespace ApiBaseProject.Dtos;
using System.ComponentModel.DataAnnotations;

public class ProductCreateDto
{
    [Required(ErrorMessage = "Name is required")]
    [RegularExpression(@"\S+", ErrorMessage = "Name cannot be just spaces")]
    public string Name { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }
}

public class ProductReadDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}