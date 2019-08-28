using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Web.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(5)]
        public string Name { get; set; }
        [Required(ErrorMessage = "**this field is required**")]
        [Display(Name = "Period (Days)")]
        public int Period { get; set; }
    }
}