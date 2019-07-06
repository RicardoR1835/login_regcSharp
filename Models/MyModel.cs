using System;
using System.ComponentModel.DataAnnotations;

namespace login_reg.Models
{
    public class RegUser
    {
        [Required]
        [MinLength(2)]
        public string FName {get;set;}

        [Required]
        [MinLength(2)]
        public string LName {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string PasswordConfirm {get;set;}
    }

    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }

    public class IndexViewModel
    {
        public RegUser NewUser {get;set;}
        public LogUser OldUser {get;set;}
    }
}