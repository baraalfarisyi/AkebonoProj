using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkebonoProj.Models;
using Microsoft.AspNetCore.Identity;

namespace AkebonoProj.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AkebonoProjUser class
public class AkebonoProjUser : IdentityUser<Guid>
{
    public virtual Karyawan Karyawan { get; set; }
}

public class ApplicationRole : IdentityRole<Guid>
{
}

