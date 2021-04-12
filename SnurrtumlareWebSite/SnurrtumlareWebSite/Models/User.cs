using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnurrtumlareWebSite.Models
{
    public class User
    {
        public int UserId { get; set; }

        [RegularExpression(@"^([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]+)$",
            ErrorMessage = "Firstname must start with capitol letter")]
        public string FirstName { get; set; }

        [RegularExpression(@"^([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]+)$",
            ErrorMessage = "Firstname must start with capitol letter")]
        public string LastName { get; set; }

        [RegularExpression(@"^(([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]\w*[a-zåäö]+)+\s?\d{0,3})+$",
            ErrorMessage = "Adress must start with capitol letter with optional second part and digits at end")]
        public string Address { get; set; }

        [RegularExpression(@"^\d{3}\s?\d{2}$",
            ErrorMessage = "Valid Zip Code format 123 45")]
        public string ZipCode { get; set; }

        [RegularExpression(@"^([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]+)$",
            ErrorMessage = "City name must start with capitol letter and can have a optional second part")]
        public string City { get; set; }

        [RegularExpression(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$",
            ErrorMessage = "Valid Email formats are firstname.lastname@domain.com, something@domain.com")]
        [Required]
        public string Email { get; set; }

        [RegularExpression(@"^(\+?\d{2}\-?\s?)?\d{4}\-?\s?\d{3}\-?\s?\d{3}$",
            ErrorMessage = "Valid phone no formats +46 0707-123 456, +46 0707-123456, +46 0707-123-456, 0707 123 456")]
        public string Phone { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
