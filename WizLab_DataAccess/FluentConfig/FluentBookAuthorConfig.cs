using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizLab_Model.Models;

namespace WizLab_DataAccess.FluentConfig
{
    public class FluentBookAuthorConfig : IEntityTypeConfiguration<Fluent_BookAuthor>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookAuthor> modelBuilder)
        {
            //many to many relation bettwen book and author
            //modelBuilder.HasKey(ba => new { ba.Author_Id, ba.Book_Id });
            //modelBuilder
            //    .HasMany(b => b.Fluent_Author)
            //    .WithMany(b => b.Fluent_Books);

            //Old EF:
            modelBuilder.HasKey(ba => new { ba.Author_Id, ba.Book_Id });
            modelBuilder
                .HasOne(b => b.Fluent_Book)
                .WithMany(b => b.Fluent_BookAuthors).HasForeignKey(b => b.Book_Id);
            modelBuilder
                .HasOne(b => b.Fluent_Author)
                .WithMany(b => b.Fluent_BookAuthors).HasForeignKey(b => b.Author_Id);


            //modelBuilder.Entity<Fluent_Author>()
            //    .HasMany(e => e.Fluent_Books)
            //    .WithMany(e => e.Fluent_Authors)
            //    .UsingEntity<BookAuthor>(
            //    bg => bg
            //        .HasOne(bg => bg.Book)
            //        .WithMany()
            //        .HasForeignKey("BookId"),
            //    bg => bg
            //        .HasOne(bg => bg.Fluent_Author)
            //        .WithMany()
            //        .HasForeignKey("Author_Id"))
            //    .ToTable("BookAuthors")
            //    .HasKey(bg => new { bg.Book_Id, bg.Author_Id });

        }
    }
}
