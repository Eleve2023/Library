using Domain.Entities.LibraryManagement.Borrowings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration.LibraryManagement.Borrowings
{
    public class BorrowingAlertViewConfiguration : IEntityTypeConfiguration<BorrowingAlertView>
    {
        public void Configure(EntityTypeBuilder<BorrowingAlertView> builder)
        {
            builder.HasNoKey();
            builder.ToView("BorrowingAlertView");
        }
    }

}
