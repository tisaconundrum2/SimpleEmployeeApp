﻿using System.ComponentModel.DataAnnotations;

namespace SimpleEmployeeApp.Models.DomainModels
{
    public class Employee
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

        [Required(ErrorMessage = "Please enter a valid date MM-DD-YYYY.")]
        [MaxLength(200)]
        public DateTime dateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter a valid SSN 111-22-3333.")]
        [MaxLength(11)]
        public string socialSecurityNumber { get; set; }
    }
}
