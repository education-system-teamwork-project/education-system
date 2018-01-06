namespace education.system.App.Areas.Admin.Models.Category
{
    using System.ComponentModel.DataAnnotations;

    public class CategoryAddModel
    {
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 60 symbols long.")]
        public string Name { get; set; }
    }
}
