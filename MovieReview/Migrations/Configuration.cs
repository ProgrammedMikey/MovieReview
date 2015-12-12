namespace MovieReview.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<global::MovieReview.Models.MovieDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
  

        protected override void Seed(MovieReview.Models.MovieDb context)
        {
            //  This method will be called after migrating to the latest version.

            

            context.Movies.AddOrUpdate(r => r.MovieName,
                new Movie { MovieName = "Avatar", DirectorName = "James Cameron", ReleaseYear = "2009" },
                new Movie { MovieName = "Titanic", DirectorName = "James Cameron", ReleaseYear = "1997" },
                new Movie { MovieName = "Die Another Day", DirectorName = "Lee Tamahori", ReleaseYear = "2002" },
                new Movie
                {
                    MovieName = "Godzilla",
                    DirectorName = "Gareth Edwards",
                    ReleaseYear = "2014",
                    reviews = new List<MovieReviews>{
                       new MovieReviews{ReviewerRating=5,ReviewerComments="Excellent",ReviewerName="Rahul Sahay"}
                   }
                });
            //for (int i = 0; i < 100; i++)
            //{
            //    context.Movies.AddOrUpdate(m => m.MovieName,
            //    new Movie { MovieName = "Anony_Movie_" + i.ToString(), DirectorName = "Anony_Director_" + i.ToString(), ReleaseYear = "2014" });
            //}

           
        }

    }
}
