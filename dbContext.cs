using Microsoft.EntityFrameworkCore;
using P2_2020RC6005_2020UL601.Models;

namespace P2_2020RC6005_2020UL601
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }

        public DbSet<Generos> generos { get; set; }
        public DbSet<Departamentos> departamentos { get; set; }
        public DbSet<CasosReportados> casosReportados { get; set; }

    }
}
