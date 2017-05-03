using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Property.Data.DMClasses;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Property.Data.Migrations
{



    public sealed class DbMigrationsConfig : DbMigrationsConfiguration<Property.Data.ApplicationDbContext>
    {
        public DbMigrationsConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                //if there are no users then create an admin account
                var adminEmail = "admin@admin.com";
                var adminUserName = adminEmail;
                var adminFullName = "System Administrator";
                var adminPassword = adminEmail;
                string adminRole = "Administrator";
                CreateAdminUser(context, adminEmail, adminUserName, adminFullName, adminPassword, adminRole);
                CreateSeveralListings(context);
            }
        }

        private void CreateAdminUser(ApplicationDbContext context, string adminEmail, string adminUserName, string adminFullName, string adminPassword, string adminRole)
        {
            // Create the "admin" user
            var adminUser = new ApplicationUser
            {
                UserName = adminUserName,
                FullName = adminFullName,
                Email = adminEmail
            };
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };
            var userCreateResult = userManager.Create(adminUser, adminPassword);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }

            // Create the "Administrator" role
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(adminRole));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }

            // Add the "admin" user to "Administrator" role
            var addAdminRoleResult = userManager.AddToRole(adminUser.Id, adminRole);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void CreateSeveralListings(ApplicationDbContext context)
        {
            context.Listings.Add(new Listing()
            {

                StreetAddress = "Seed St 1",
                Town = "Glasgow"

            });

            context.Listings.Add(new Listing()
            {

                StreetAddress = "Seed St 2",
                Town = "Edinburgh"

            });

            context.Listings.Add(new Listing()
            {

                StreetAddress = "Seed St 3",
                Town = "Dundee"

            });

            context.Listings.Add(new Listing()
            {

                StreetAddress = "Seed St 4",
                Town = "Aberdeen"

            });

            context.Listings.Add(new Listing()
            {

                StreetAddress = "Seed St 5",
                Town = "Inverness"

            });

            context.Listings.Add(new Listing()
            {

                StreetAddress = "Seed St 6",
                Town = "Stirling"

            });

            context.SaveChanges();
        }


    }
}

