namespace Hackathon06.Contact
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class TextModel : DbContext
    {
        public TextModel()
            : base("name=TextModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<TextTable> TextTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TextTable>()
                .Property(e => e.TickNumber)
                .IsUnicode(false);
        }
    }
}
