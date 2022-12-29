using SimpleEmployeeApp.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http.Headers;
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
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string socialSecurityNumber { get; set; }

        public Employee() { }

        /*
         * A DTO is best for dealing with Casting and Security
         * With a datatype we can prevent possible Data Binding Attacks
         * and for the DOB we can do Parse so we can get the input string to a DateTime
         */

        public EmployeeDTO Transfer(Employee emp, EmployeeDTO dto)
        {
            dto.Id = emp.Id;
            dto.firstName = emp.firstName;
            dto.middleInitial = emp.middleInitial;
            dto.lastName = emp.lastName;
            dto.address = emp.address;
            dto.city = emp.city;
            dto.state = emp.state;
            dto.zip= emp.zip;
            dto.dateOfBirth = emp.dateOfBirth.ToString("MM-dd-yyyy");
            dto.socialSecurityNumber = emp.socialSecurityNumber;
            return dto;
        }

        public Employee Transfer(EmployeeDTO dto, Employee emp)
        {
            emp.Id = dto.Id;
            emp.firstName = dto.firstName;
            emp.middleInitial = dto.middleInitial;
            emp.lastName = dto.lastName;
            emp.address = dto.address;
            emp.city = dto.city;
            emp.state = dto.state;
            emp.zip = dto.zip;
            emp.dateOfBirth = DateTime.Parse(dto.dateOfBirth);
            emp.socialSecurityNumber = dto.socialSecurityNumber;
            return emp;
        }
    }
}
