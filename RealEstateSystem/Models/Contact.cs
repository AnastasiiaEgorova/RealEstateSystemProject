using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RealEstateSystem.RoleInfo;

namespace RealEstateSystem.Models
{
    public class Contact
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Access Level")]
        public string AccessLevel { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [MinLength(2, ErrorMessage = "User Name must be at least 2 characters")]
        [MaxLength(32, ErrorMessage = "User Name must be no longer than 32 characters")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "SIN")]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "SIN must contain 9 digits")]
        public int SIN { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        [MaxLength(32, ErrorMessage = "First Name must be no longer than 32 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [MinLength(2, ErrorMessage = "Middle Name must be at least 2 characters")]
        [MaxLength(32, ErrorMessage = "Middle Name must be no longer than 32 characters")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters")]
        [MaxLength(32, ErrorMessage = "Last Name must be no longer than 32 characters")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        [MinLength(10, ErrorMessage = "Address must be at least 10 characters")]
        [MaxLength(128, ErrorMessage = "Address must be no longer than 128 characters")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        [MinLength(2, ErrorMessage = "City must be at least 2 characters")]
        [MaxLength(64, ErrorMessage = "City must be no longer than 64 characters")]
        public string Municipality { get; set; }

        [Required]
        [Display(Name = "Province")]
        [MinLength(2, ErrorMessage = "Province must be at least 2 characters")]
        [MaxLength(64, ErrorMessage = "Province must be no longer than 64 characters")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [MaxLength (6, ErrorMessage = "Postal Code must contain 6 characters")]
        public string PostalCode { get; set; }

        [Display(Name = "Home Phone")]
        [RegularExpression(@"^([\+]?(?:00)?[0-9]{1,3}[\s.-]?[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$", ErrorMessage = "Invalid phone number")]
        public string HomePhoneNumber { get; set; }

        [Required]
        [Display(Name = "Cell Phone")]
        [RegularExpression(@"^([\+]?(?:00)?[0-9]{1,3}[\s.-]?[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$", ErrorMessage = "Invalid phone number")]
        public string CellPhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
        public string OfficeEmail { get; set; }

        [Required]
        [Display(Name = "Office Phone")]
        [RegularExpression(@"^([\+]?(?:00)?[0-9]{1,3}[\s.-]?[0-9]{1,12})([\s.-]?[0-9]{1,4}?)$", ErrorMessage = "Invalid phone number")]
        public string OfficePhoneNumber { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [RegularExpression(@"^(0?[1-9]|[12][0-9]|3[01])[\/](0?[1-9]|1[012])[\/]\d{4}$", ErrorMessage = "Date of Birth must be in format dd/mm/yyyy")]
        //TO DO [Range(01/01/1900, 01/01/2002)]
        public string DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Created By")]
        public string UserCreatedBy { get; set; }

        [Required]
        [Display(Name = "User Creation Date")]
        public string DateCreated { get; set; }
    }
}