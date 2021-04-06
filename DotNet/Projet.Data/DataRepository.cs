using Microsoft.EntityFrameworkCore;

namespace Projet.Data
{
    public class DataRepository : DbContext
    {
        public DataRepository(DbContextOptions options)
            : base(options)
        {
        }
    }
}