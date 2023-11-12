using Microsoft.EntityFrameworkCore;

namespace JWT_Auth.Data.Dbcontexts
{
    public class UserContext : DbContext
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

    }
}
