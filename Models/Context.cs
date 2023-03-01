using System.Collections.Generic;
using System.Xml;
using Cakeshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


public class Context : DbContext
{
    public DbSet<ADMINISTRATOR> ADMINISTRATOR { get; set; }
    public DbSet<CATEGORY> CATEGORY { get; set; }
    public DbSet<CUSTERMOR> CUSTERMOR { get; set; }
    public DbSet<ORDER> ORDER { get; set; }
    public DbSet<PAYMENT> PAYMENT { get; set; }
    public DbSet<PRODUCT> PRODUCT { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;uid=root;pwd=achini123#;database=cakeshop", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
        }
    }
}