using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecordStore.Models
{
    public class User : IValidatableObject
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DisplayName("Det aller sidste navn ever!!")]
        [DataType(DataType.MultilineText)]
        public string LastName { get; set; }

        [Required] 
        [StringLength(100)]
        public string Username { get; set; }

        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        // Or you can use: [RegularExpression(@"^[a - zA - Z0 - 9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Ikke en gyldig email adresse")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            return new[] { new ValidationResult("Date wrong", new[] { "DateOfBirth" }) };
        }
    }
}