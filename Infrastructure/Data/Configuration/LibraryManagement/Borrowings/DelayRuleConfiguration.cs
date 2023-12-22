using Domain.Entities.LibraryManagement.Borrowings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration.LibraryManagement.Borrowings
{
    public class BorrowRuleConfiguration : IEntityTypeConfiguration<BorrowRule>
    {
        public void Configure(EntityTypeBuilder<BorrowRule> builder)
        {
        }
    }

}
