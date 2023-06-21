using SwimmingClub.Enums;
using System;
namespace SwimmingClub.Entities.Payments;

public sealed class Payment : Auditable
{
    public long ClientId { get; set; }

    public PaymentType PaymentType { get; set; }

    public string Description { get; set; } = String.Empty;
}