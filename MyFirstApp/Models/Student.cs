using System.ComponentModel.DataAnnotations;

namespace MyFirstApp.Models
{
    public class Student
    {
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        public string Course {  get; set; }
        [Required]
        public string Email { get; set; }


    }
}
