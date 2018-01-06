namespace education.system.Services.Models.Category
{
    using Data.Models;
    using Infrastructure.AutoMapper;
    using System.ComponentModel.DataAnnotations;

    public class CategoryBaseModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 60 symbols long.")]
        public string Name { get; set; }
    }
}
