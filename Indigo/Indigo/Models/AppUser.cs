﻿using Microsoft.AspNetCore.Identity;

namespace Indigo.Models
{
    public class AppUser:IdentityUser
    {
            public string FullName { get; set; }
            public string Password { get; set; }

    }
}

