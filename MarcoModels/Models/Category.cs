using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MarcoModels.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
    [DisplayName("Category Name")]
    public required string Name { get; set; }
    
    [DisplayName("Category Order")]
    [Range(1,100, ErrorMessage = "Please enter a number between 1 and 100")]
    public int DisplayOrder { get; set; }
    
}