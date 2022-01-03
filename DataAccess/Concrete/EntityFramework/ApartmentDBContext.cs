﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ApartmentDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-9d6tod0\sqlexpress;Database=ApartmentManage;Trusted_Connection=true");
           

        }


        public DbSet<Payment> Payments { get; set; }
        public DbSet<Dues> Duess{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
    }
}
