using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocAauth.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserApp, RoleApp, int, UserClaimApp,
        UserRoleApp, UserLoginApp, RoleClaimApp, UserTokenApp>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserApp> UserApps { get; set; }
        public DbSet<OTPSignIn> OTPSignIns { get; set; }

        public OTPSignIn GetOneTimePassword(int userId, string code)
        {
            return OTPSignIns.FirstOrDefault(otp => otp.UserAppId == userId && otp.Code == code && otp.ExpirationTime > DateTime.Now);
        }

        public void CreateOneTimePassword(int userId, string code, int expirationTimeInMinutes)
        {
            OTPSignIns.Add(new OTPSignIn { UserAppId = userId, Code = code, ExpirationTime = DateTime.Now.AddMinutes(expirationTimeInMinutes) });
            SaveChanges();
        }

    }
}
