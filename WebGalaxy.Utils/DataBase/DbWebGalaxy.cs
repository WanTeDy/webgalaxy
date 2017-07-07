using System.Data.Entity;
using WebGalaxy.Utils.Entities;

namespace WebGalaxy.Utils.DataBase
{
    public class DbWebGalaxy : DbContext
    {
        public DbWebGalaxy()
        //:base("Local")
        :base("smarter")
        { }

        public DbSet<UserMail> UserMails { get; set; }
        public DbSet<UserFeedback> UserFeedbacks { get; set; }
        public DbSet<UserBrief> UserBriefs { get; set; }
        
    }
}