using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DDT1721050486.Models
{
    public partial class LapTrinhQuanLyDbContext : DbContext
    {
        public LapTrinhQuanLyDbContext()
            : base("name=Model11")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
