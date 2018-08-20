namespace MvcForumTranslator.Modules
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TransContext : DbContext
    {
        public TransContext()
            : base("name=TransContext")
        {

        }

        public TransContext(string connString)
            : base(connString)
        {

        }

        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleResourceKey> LocaleResourceKeys { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .HasMany(e => e.LocaleStringResources)
                .WithRequired(e => e.Language)
                .HasForeignKey(e => e.Language_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocaleResourceKey>()
                .HasMany(e => e.LocaleStringResources)
                .WithRequired(e => e.LocaleResourceKey)
                .HasForeignKey(e => e.LocaleResourceKey_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
