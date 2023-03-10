using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[]? AvatarImage { get; set; }
    }
}
