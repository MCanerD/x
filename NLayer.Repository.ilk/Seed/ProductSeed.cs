using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.ilk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.ilk.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { 
                    Id = 1,
                    CategoryId = 1,
                    Name = "Pilot",
                    Price = 100,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                },
                new Product { 
                    Id = 2,
                    CategoryId = 1,
                    Name = "Uclu",
                    Price = 20,
                    Stock = 30,
                    CreatedDate = DateTime.Now
                },
                new Product { 
                    Id = 3,
                    CategoryId = 1,
                    Name = "Keceli",
                    Price = 15,
                    Stock = 50,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
