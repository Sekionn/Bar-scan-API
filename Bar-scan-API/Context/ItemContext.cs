using Bar_scan_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Bar_scan_API.Context
{
    public class ItemContext(DbContextOptions<ItemContext> options) : DbContext(options)
    {
        public DbSet<Item>? Items { get; set; }
    }
}