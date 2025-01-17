﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DershaneOrnekSB.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} Boş Geçilemez!"), MaxLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez!")]
        [Display(Name = "Şifre"), DataType(DataType.Password), MaxLength(50), MinLength(3)]
        public string Password { get; set; }
        [ScaffoldColumn(false)]
        public string? ReturnUrl { get; set; }
    }
}