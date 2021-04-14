using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnurrtumlareWebSite.Models
{
    public class User
    {
        public int UserId { get; set; }

        [RegularExpression(@"^([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]+)|[*]{5}$",
            ErrorMessage = "Firstname must start with capital letter")]
        public string FirstName { get; set; }

        [RegularExpression(@"^([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]+)|[*]{5}$",
            ErrorMessage = "Lastname must start with capital letter")]
        public string LastName { get; set; }

        [RegularExpression(@"^(([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]\w*[a-zåäö]+)+\s?\d{0,3})+|[*]{5}$",
            ErrorMessage = "Address must start with capital letter with optional second part and digits at end")]
        public string Address { get; set; }

        [RegularExpression(@"^\d{5}|[*]{5}$",
            ErrorMessage = "Valid Zip Code format 12345")]
        public string ZipCode { get; set; }

        [RegularExpression(@"^([A-ZÅÄÖ]\w*[a-zåäö]+|[A-ZÅÄÖ]\w*[a-zåäö]+\s[a-zA-ZåäöÅÄÖ]+)|[*]{5}$",
            ErrorMessage = "City name must start with capital letter and can have a optional second part")]
        public string City { get; set; }

        [RegularExpression(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})|[*]{5}$",
            ErrorMessage = "Valid Email formats are firstname.lastname@domain.com, something@domain.com")]
        [Required]
        public string Email { get; set; }

        [RegularExpression(@"^\d{4}\-?\s?\d{3}\-?\s?\d{3}|[*]{5}$",
            ErrorMessage = "Valid phone no formats 0707-123 456, 0707-123456, 0707-123-456, 0707 123 456")]
        public string Phone { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
