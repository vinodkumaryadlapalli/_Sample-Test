using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test_2022F.Models;

namespace Test_2022F.Data
{
    public class DataInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            // TestNote: Create an "Admin" Role
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            ApplicationUser testUser = new ApplicationUser
            {
                Country = "Canada",
                UserName = "test@test.com",
                PasswordHash = "test@test.com",
                DateOfBirth = new DateTime(2000, 1, 1)
            };
           

            IdentityRole role1 = new IdentityRole { Name = "Admin" };
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(role1);

            // TestNote: Create a test user, set their Country to Canada, date of birth to Jan 01 2000, user name and email to test@test.com and password to testing1234
            userManager.Create(testUser, "testing1234");
            // TestNote: add the test user to the "Admin" role.
            userManager.AddToRole(testUser.Id, "Admin");


            // TestNote: Create two Books, One Book’s Edition must be 1, the other must be greater than 1, and add them to the database

            Book b1 = new Book
            {
                Id = 1,
                Published = new DateTime(2005,7,8),
                Edition = 1,
                ISBN = "987234231",
                Title = "C# Testing Book1",
         
            };
            Book b2 = new Book
            {
                Id = 2,
                Published = new DateTime(1920, 7, 8),
                Edition = 2,
                ISBN = "987234233",
                Title = "C# Testing Book2",
            };
            context.Books.Add(b1);
           context.Books.Add(b2);   
           




            base.Seed(context);
        }
    }
}