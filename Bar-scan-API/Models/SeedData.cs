using Bar_scan_API.Context;
using Microsoft.EntityFrameworkCore;

namespace Bar_scan_API.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ItemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ItemContext>>()))
            {
                // Look for any Items.
                if (context.Items.Any())
                {
                    return;   // DB has been seeded
                }

                context.SaveChanges();
            }
        }
    }
}