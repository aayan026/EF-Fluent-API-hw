using Fulent_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulent_API.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasOne<Author>()
                 .WithMany()
                 .HasForeignKey(x => x.Id_Author);

            builder.HasOne<Theme>()
                .WithMany()
                .HasForeignKey(x => x.Id_Theme);

            builder.HasOne<Press>()
                .WithMany()
                .HasForeignKey(x => x.Id_Press);
            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(x => x.Id_Category);
        }
    }
}
