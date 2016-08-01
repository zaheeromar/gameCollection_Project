namespace mvcGameCollection.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using mvcGameCollection.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<mvcGameCollection.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mvcGameCollection.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(i => i.Title,
            new Game
            {
                Title = "Wolfenstein: The New Order",
                Company = "Machine Games",
                ReleaseDate = DateTime.Parse("2014-5-20"),
                Genre = "FPS",
                HoursToBeat = 11.50M,
                Rating = "https://upload.wikimedia.org/wikipedia/en/9/95/Wolfenstein_The_New_Order_cover.jpg"
            },

             new Game
             {
                 Title = "Wolfenstein: The Old Blood",
                 Company = "Machine Games",
                 ReleaseDate = DateTime.Parse("2015-5-15"),
                 Genre = "FPS",
                 HoursToBeat = 6.00M,
                 Rating = "https://upload.wikimedia.org/wikipedia/en/0/0d/Wolfenstein_The_Old_Blood_cover.jpg"
             },

             new Game
             {
                 Title = "Infamous Second Son",
                 Company = "Sucker Punch",
                 ReleaseDate = DateTime.Parse("2014-3-21"),
                 Genre = "Action-Adventure",
                 HoursToBeat = 10.00M,
                 Rating = "https://upload.wikimedia.org/wikipedia/en/3/34/Infamous_second_son_boxart.jpg"
             },

             new Game
             {
                 Title = "Infamous First Light",
                 Company = "Sucker Punch",
                 ReleaseDate = DateTime.Parse("2014-8-27"),
                 Genre = "Action-Adventure",
                 HoursToBeat = 4.00M,
                 Rating = "https://upload.wikimedia.org/wikipedia/en/1/15/Infamous_First_Light_cover_art.jpg"
             });
        }
    }
}
