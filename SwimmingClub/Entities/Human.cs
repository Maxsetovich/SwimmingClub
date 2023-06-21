using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System;
using SwimmingClub.Enums;

namespace SwimmingClub.Entities;

public class Human : Auditable
{
    [MaxLength(50)]
    public string FirstName { get; set; } = String.Empty;

    [MaxLength(50)]
    public string LastName { get; set; } = String.Empty;

    public DateOnly Date_of_birth { get; set; }

    public Gender Gender { get; set; }

    [MaxLength(50)]
    public string Email { get; set; } = String.Empty;

    [MaxLength(15)]
    public string PhoneNumber { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;
}

