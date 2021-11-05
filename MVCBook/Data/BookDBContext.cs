using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;//AGREGAR
using MVCBook.Models;//AGREGAR


namespace MVCBook.Data
{
    public class BookDBContext : DbContext
    {

        public BookDBContext() : base("KeyDB") { }
        public DbSet<Book> Books { get; set; }
    }
}