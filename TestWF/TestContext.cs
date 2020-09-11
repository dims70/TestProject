namespace TestWF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestContext : DbContext
    {
        public TestContext()
            : base("name=TestContext")
        {
        }

        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Research> Research { get; set; }

        public virtual DbSet<Role> Role { get; set; }

        public virtual DbSet<Tehnician> Tehnician { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
