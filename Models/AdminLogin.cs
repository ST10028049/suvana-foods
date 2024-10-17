﻿using System.ComponentModel.DataAnnotations;

namespace SuvanaFoods.Models
{
    public class AdminLogin
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}