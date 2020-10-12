using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCSkillsAssessment_CodeFirst.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required.")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Last Name  is Required.")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is Required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_]).{8,15})", ErrorMessage = "Password must be atleast 8 example Abcd!@un")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is Required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Country ")]
        public string Country { get; set; }

        [Display(Name = "Favourite Colour ")]
        public string FavouriteColour { get; set; }

        [Display(Name = "Birthday ")]
        [DataType(DataType.Date)]
        public string Birthday { get; set; }

        [Display(Name = "Cellphone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10), MinLength(10)]
        public string Cellphone { get; set; }

        [Display(Name = "Comments")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }
}
    
