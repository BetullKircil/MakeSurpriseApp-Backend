﻿using System;
using System.Collections.Generic;

namespace MakeSurpriseProject.Entities;

public partial class UserProfile
{
    public int ProfileId { get; set; }

    public int UserId { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual User User { get; set; } = null!;
}
