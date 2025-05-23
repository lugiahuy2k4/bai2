﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace Week2_2280601159.Models;
public class ApplicationUser : IdentityUser
{
    [Required]
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? Age { get; set; }
}

