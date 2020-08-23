using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wholesale.Domain.Common.Base;
using Wholesale.Domain.Common.Utilities;

namespace Wholesale.Infrastructure
{
    public class WholesaleContext : DbContext
    {
        public WholesaleContext(DbContextOptions<WholesaleContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {            
            var entitiesAssembly = typeof(IEntity).Assembly;


            builder.RegisterAllEntities<IEntity>(entitiesAssembly);  
            builder.RegisterEntityTypeConfiguration(entitiesAssembly);
            builder.AddRestrictDeleteBehaviorConvention();
            builder.AddSequentialGuidForIdConvention();
            builder.AddPluralizingTableNameConvention();

            base.OnModelCreating(builder);
        }
    }
}
