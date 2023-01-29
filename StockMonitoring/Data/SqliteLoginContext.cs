using Microsoft.EntityFrameworkCore;
using StockMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMonitoring.Data
{
    public class SqliteLoginContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite(@"Data Source=C:\stock\db\login.db3");

    }
}
