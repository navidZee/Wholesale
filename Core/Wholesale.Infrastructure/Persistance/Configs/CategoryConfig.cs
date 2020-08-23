using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wholesale.Domain.Entities.PRT;

namespace Wholesale.Infrastructure.Persistance.Configs
{
    class CategoryConfig : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            
        }
    }

}
