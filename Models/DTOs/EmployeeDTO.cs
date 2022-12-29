using System.ComponentModel.DataAnnotations;

namespace SimpleEmployeeApp.Models.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter First Name.")]
        [MaxLength(200)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please enter a Middle initial.")]
        [MaxLength(2)]
        public string middleInitial { get; set; }

        [Required(ErrorMessage = "Please enter Last Name.")]
        [MaxLength(200)]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Please enter an Address.")]
        [MaxLength(1000)]
        public string address { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        [MaxLength(200)]
        public string city { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        [MaxLength(200)]
        public string state { get; set; }

        [Required(ErrorMessage = "Please enter a valid Zip")]
        [MaxLength(5)]
        public string zip { get; set; }

        [Required(ErrorMessage = "Please enter a valid date MM-DD-YYYY.")]
        [MaxLength(10)]
        public string dateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter a valid SSN 111-22-3333.")]
        [MaxLength(11)]
        public string socialSecurityNumber { get; set; }
    }
}
