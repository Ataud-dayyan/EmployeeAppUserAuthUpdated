﻿using System.ComponentModel.DataAnnotations;

namespace Presentation.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
