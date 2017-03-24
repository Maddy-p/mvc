using System.Data.Entity;

namespace MVCLoginRegistration.Models
{
    public class OurDBContext: DbContext
    {
        public DbSet<Useraccount> Useraccount { get; set; }
    }
}