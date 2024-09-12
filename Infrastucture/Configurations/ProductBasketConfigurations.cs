using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Configurations
{
    internal class ProductBasketConfigurations : IEntityTypeConfiguration<ProductBasket>
    {
        public void Configure(EntityTypeBuilder<ProductBasket> builder)
        {
            builder.HasKey(pb => pb.Id);

            builder.HasOne(pb => pb.Product).WithMany(p => p.ProductBaskets).HasForeignKey(pb => pb.ProductId);
            builder.HasOne(pb => pb.Basket).WithMany(b => b.ProductBaskets).HasForeignKey(pb => pb.BasketId);
        }
    }
}
