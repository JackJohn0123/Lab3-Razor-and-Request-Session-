using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IntroToASP.NETMVC.Models
{
    public class LoginInformationModel
    {
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string EmailAddress
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        [BindProperty(Name = "pass")]
        public string Password
        {
            get;
            set;
        }


        [Required]
        [Range(0, 100)] 
        [BindProperty(Name = "studentNumber")]
        public int studentNumber
        {
            get; set;
        }

        [Required]
        [StringLength(100)]
        [BindProperty(Name = "FirstName")]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        [BindProperty(Name = "LastName")]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        [BindProperty(Name = "Description")]
        public string Description
        {
            get;
            set;
        }

    }
}
