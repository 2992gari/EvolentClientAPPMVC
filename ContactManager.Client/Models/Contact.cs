using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactManager.Client.Models
{
    public class Contact
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [StringLength(7), Required]
        [RegularExpression("^[a-zA-Z]{1,20}$", ErrorMessage = "Enter only Alphabet for First Name")]
        public string FirstName { get; set; }

        [StringLength(7), Required]
        [RegularExpression("^[a-zA-Z]{1,20}$", ErrorMessage = "Enter only Alphabet for Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Number is not valid")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Status")]        
        public ContactStatus Status { get; set; }
    }
    public enum ContactStatus
    {
        Active,
        Inactive
    }

}