using Domain.Entities.LibraryManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infrastructure.Data.Configuration.LibraryManagement
{
    public class FineConfiguration : IEntityTypeConfiguration<Fine>
    {
        public void Configure(EntityTypeBuilder<Fine> builder)
        {
            builder.HasOne(f => f.LibraryCard)
                .WithMany()
                .HasForeignKey(f => f.LibraryCardId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(f => f.Borrowing)
                .WithMany()
                .HasForeignKey(f => f.BorrowingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
