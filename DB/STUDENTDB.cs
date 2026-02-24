using Day1_Workshop.Models;
using Microsoft.EntityFrameworkCore;

namespace societymanagement
{
    public class STUDENTDB : DbContext
    {
        public STUDENTDB(DbContextOptions options) : base(options)
        {
        }

       public DbSet<StudentModel> STUDENTS { get; set; }
    }
}
