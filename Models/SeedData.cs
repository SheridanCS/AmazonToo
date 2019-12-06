using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonToo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AmazonDbContext(serviceProvider.GetRequiredService<DbContextOptions<AmazonDbContext>>()))
            {
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.Add(
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Name = "Timothy Catibog",
                        Email = "catibogt@sheridancollege.ca",
                        IsPrimeMember = true,
                        Addresses = new List<UserAddress>() {
                            new UserAddress
                            {
                                AddressLine1 = "123 Fake Street",
                                AddressLine2 = "",
                                Province = Province.ON,
                                Country = Country.CA
                            }
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}