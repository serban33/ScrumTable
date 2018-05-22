namespace ScrumTable.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=ContextConnection")
        {
        }

        public virtual DbSet<Drafts> Drafts { get; set; }
        public virtual DbSet<Story> Story { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drafts>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Story>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Story>()
                .Property(e => e.Content)
                .IsUnicode(false);

            
        }
    }
}
