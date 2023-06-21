using SwimmingClub.Helpers;
using System;

namespace SwimmingClub.Entities;

public abstract class Auditable : BaseEntity
{
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Auditable()
    {
        CreatedAt = TimeHelper.GetDateTime();
        UpdatedAt = TimeHelper.GetDateTime();
    }
}
