using BookService.Models;

namespace BookService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() {Id = 1, Name = "Jon Galloway" },
                new Author() {Id = 2, Name = "Jamie Kurtz"},
                new Author() {Id = 3, Name = "Adam Freeman"}
                );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Professional ASP.NET MVC 5",
                    Year = 2014,
                    AuthorId = 1,
                    Price = 36.90M,
                    Genre = "Nerd"
                },
                new Book()
                {
                    Id = 2,
                    Title = "ASP.NET Web API 2",
                    Year = 2014,
                    AuthorId = 2,
                    Price = 26.58M,
                    Genre = "Nerd"
                },
                new Book()
                {
                    Id = 3,
                    Title = "Pro AngularJS ",
                    Year = 2014,
                    AuthorId = 3,
                    Price = 40.22M,
                    Genre = "Nerd"
                }
        
                );
        }
    }
}
