using System;
using Microsoft.EntityFrameworkCore;

namespace eKart.Api.Model
{
    public interface IDatasourceContext: IDisposable
    {
        DbSet<Product> Products{ get; set; }
        int SaveChanges();
    }
}