using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SnachFrame.Data
{
    public class SnachFrameDbContext : IdentityDbContext
    {
        public SnachFrameDbContext(DbContextOptions<SnachFrameDbContext> options)
            : base(options)
        {
        }
    }
}