using System;

namespace SwimmingClub.Entities.Attendance;

public sealed class Attendance : Auditable
{
    public long ClientId { get; set; }

    public long SessionId { get; set; }

    public string Description { get; set; } = String.Empty;
}
