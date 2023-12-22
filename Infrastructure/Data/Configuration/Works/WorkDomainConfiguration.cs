using Domain.Entities.Works;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration.Works
{
    public class WorkDomainConfiguration : IEntityTypeConfiguration<WorkDomain>
    {
        public void Configure(EntityTypeBuilder<WorkDomain> builder)
        {

        }
    }

}
