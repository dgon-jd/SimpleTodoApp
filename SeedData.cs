using System;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreTodo {
    public static class SeedData {
        public static async Task InitializeAsync(IServiceProvider services) {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            await EnsureRolesAsync(roleManager);

            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            await EnsureAdminAsync(userManager);
        }

        private static async Task EnsureAdminAsync(UserManager<ApplicationUser> userManager)
        {
            var testAdmin = await userManager.Users
            .Where(user => user.Email == "admin@techfabric.io")
            .SingleOrDefaultAsync();

            if (testAdmin != null) return;

            testAdmin = new ApplicationUser {
                UserName = "App Admin",
                Email = "admin@techfabric.io"
            };

            await userManager.CreateAsync(testAdmin, "Admin_pass123!");
            await userManager.AddToRoleAsync(testAdmin, Constants.AdministratorRole);
        }

        private static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager) {
            var alreadyExists = await roleManager.RoleExistsAsync(Constants.AdministratorRole);

            if (alreadyExists) return;

            await roleManager.CreateAsync(
                new IdentityRole(Constants.AdministratorRole)
            );
        }
    }
}