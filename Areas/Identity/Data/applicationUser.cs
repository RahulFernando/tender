using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ceb_tender_app.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the applicationUser class
    public class applicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string DisplayName { get; set; }
    }
}
