namespace education.system.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Resource name must be between 3 and 60 symbols long.")]
        public string Name { get; set; }

        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }

        //TODO: What else should the resource contain?
    }
}
