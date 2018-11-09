using System;
using Microsoft.EntityFrameworkCore;

namespace eKart.Api.Model
{
    public class SQLServerContext: DbContext, IDatasourceContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options):base(options)
        {}
        public DbSet<Product> Products{get; set; }
    }
}