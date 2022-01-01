using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class User
    {
        public Int64 ID { get; set; }

        [Required(ErrorMessage="Enter Your username.")]
        public string Username { get; set; }


        [Required]
        [StringLength(20,ErrorMessage ="Your password must be at least 6 characters long!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Your Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Your Surname.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Choose Your Birth Date.")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Enter Your Phone Number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter Your Email.")]
        [EmailAddress(ErrorMessage ="Enter Your Email in Correct Form!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Choose Your Gender!")]
        [StringLength(1, ErrorMessage = "Choose Your Gender!")]
        public string Gender { get; set; }
        public string WantsToReadList { get; set; }
        public string ReadAlreadyList { get; set; }
        public string NowReading { get; set; }
        public string BooksOwned { get; set; }
        public string UserType { get; set; }
        public string About { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string Pinterest { get; set; }
    }
}
