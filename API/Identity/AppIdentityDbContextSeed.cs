using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName ="Kingsley",
                    Email = "kingusei@yahoo.com",
                    UserName = "kingusei@yahoo.com",
                    Address = new Address
                    {
                        FirstName = "Kingsley",
                        LastName = "Owusu",
                        Organisation = "Ministry of Gender",
                        Designation = "Senior Programmer",
                        Region = "Greater Accra"
                    }
                };
            await userManager.CreateAsync(user, "P@55w0rd");
            }
        }
    }
}