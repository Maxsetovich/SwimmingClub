using System;
namespace SwimmingClub.Entities.Admins;

public sealed class Admin : Human
{
    public string Password { get; set; } = String.Empty;
}
