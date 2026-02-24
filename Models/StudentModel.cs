using System.ComponentModel.DataAnnotations;

namespace Day1_Workshop.Models
{
    public class StudentModel
    {
        [Key]
        public int student_id { get; set; }

        [Required(ErrorMessage = "enter the name")]
        public required string student_name { get; set; }

        [Required(ErrorMessage = "enter the branch")]
        public string? studentbrach { get; set; }

        [EmailAddress, Required(ErrorMessage = "enter the email")]
        public string? student_email { get; set; }

        [Required(ErrorMessage = "enter the DOB")]
        public DateOnly DOB { get; set; }

        [Required(ErrorMessage = "enter the city")]
        public string? city { get; set; }



    }
}
