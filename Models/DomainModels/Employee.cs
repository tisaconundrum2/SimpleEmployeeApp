using SimpleEmployeeApp.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Policy;

namespace SimpleEmployeeApp.Models.DomainModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string socialSecurityNumber { get; set; }

        public Employee() { }

        /*
         * A DTO is best for dealing with Casting and Security
         * With a datatype we can prevent possible Data Binding Attacks
         * and for the DOB we can do Parse so we can get the input string to a DateTime
         */
        public Employee(EmployeeDTO dto)
        {
            Id = dto.Id;
            firstName = dto.firstName;
            middleInitial = dto.middleInitial;
            lastName = dto.lastName;
            address = dto.address;
            dateOfBirth = DateTime.Parse(dto.dateOfBirth);
            socialSecurityNumber = dto.socialSecurityNumber;
        }
    }
}
