using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateSystem.Models
{
    public class Contact
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public int SIN { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string Municipality { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string PostalCode { get; set; }

        public string HomePhoneNumber { get; set; }

        [Required]
        public string CellPhoneNumber { get; set; }

        [Required]
        public string OfficeEmail { get; set; }

        [Required]
        public string OfficePhoneNumber { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserCreatedBy { get; set; }

        [Required]
        public string DateCreated { get; set; }
    }
}