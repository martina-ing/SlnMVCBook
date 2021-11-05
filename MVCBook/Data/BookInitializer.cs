using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity; //AREGAR
using MVCBook.Models; //AGREGAR

namespace MVCBook.Data
{
    public class BookInitializer : DropCreateDatabaseAlways<BookDBContext>
    {
        protected override void Seed(BookDBContext context)
        {
            var bookslist = new List<Book>
            {
               new Book {
                  Name = "Rayuela",
                  Author = "Julio Cortázar",
                  PagesNumber =1000,
                  Price = 1200,
                  PriceConfirm = 1200 ,
                  Publisher = "Pantheon Books",
                  PublicationDate = "1963-02-18"

               }
            };
            bookslist.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

        }
    }
}