using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class User
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name e.g. John Doe")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare("Email")]
        public string RetypeEmail { get; set; }

        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [Required]
        public string Cnic { get; set; }

        [Range(18, 25)]
        public string Age { get; set; }

        [StringLength(35)]
        public string City { get; set; }

        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
    }
}
