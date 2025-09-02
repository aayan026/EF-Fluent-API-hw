using Fulent_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulent_API.Configurations
{
    internal class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.Ignore(x => x.Id);
            builder.Ignore(x => x.CreatedDate);
            builder.Ignore(x => x.ModifiedDate);

            builder.HasNoKey();

            builder.HasOne<Teacher>()
                  .WithMany()
                  .HasForeignKey(x => x.Id_Teacher);

            builder.HasOne<Book>()
                   .WithMany()
                   .HasForeignKey(x => x.Id_Book);
            builder.HasOne<Libs>()
                .WithMany()
                .HasForeignKey(x => x.Id_lib);
        }
    }
}
