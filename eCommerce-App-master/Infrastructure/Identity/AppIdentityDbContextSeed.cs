using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Aishwarya K",
                    Email = "aish@aish.com",
                    UserName = "aish@aish.com",
                    Address = new Address
                    {
                        FirstName = "Aish",
                        LastName = "K",
                        Street = "8",
                        City = "Pune",
                        State = "MH",
                        Zipcode = "411038"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}