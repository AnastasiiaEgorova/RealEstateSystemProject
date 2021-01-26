using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RealEstateSystem.Models;
using RealEstateSystem.RoleInfo;

namespace RealEstateSystem.Utility
{
    public static class RoleUtility
    {
        public static void CreateDefaultRoles()
        {
            var context = ApplicationDbContext.Create();
            var roleManager = context.CreateRoleManager();

            roleManager.CreateRole(RoleNames.Administrator);
            roleManager.CreateRole(RoleNames.OfficeManager);
            roleManager.CreateRole(RoleNames.Agent);
        }

        public static List<string> CreateListOfRoles()
        {
            List<string> roles = new List<string>();

            roles.Add(RoleNames.Administrator);
            roles.Add(RoleNames.OfficeManager);
            roles.Add(RoleNames.Agent);

            return roles;
        }

        public static RoleManager<IdentityRole> CreateRoleManager(this ApplicationDbContext context)
        {
            return new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        public static void CreateRole(this RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!roleManager.RoleExists(roleName))
            {
                var role = new IdentityRole { Name = roleName };
                roleManager.Create(role);
            }
        }
    }
}