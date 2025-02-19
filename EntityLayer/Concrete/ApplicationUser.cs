using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
