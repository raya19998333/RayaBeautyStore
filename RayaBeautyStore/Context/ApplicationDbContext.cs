using Microsoft.EntityFrameworkCore;
using RayaBeautyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayaBeautyStore.Context
{
        public class ApplicationDbContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                string con = "server=localhost\\MSSQLSERVER08; " +
                    "database=RayaBeautyDb;" +
                    " Integrated Security=True;" +
                    " TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(con);
            }

            public DbSet<Product> Products { get; set; }
            public DbSet<Order> Orders { get; set; }
        }
    }


