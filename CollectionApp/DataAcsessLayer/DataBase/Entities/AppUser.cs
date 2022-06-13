using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAcsessLayer.DataBase.Entities
{
   public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastNamee { get; set; }
        public string FullName{ get; set; }
        public string Info{ get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Country { get; set; }





    }
}
