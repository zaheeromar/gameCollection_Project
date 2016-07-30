namespace mvcGameCollection.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
                Rating = "18"
            },

             new Game
             {
                 Title = "Wolfenstein: The Old Blood",
                 Company = "Machine Games",
                 ReleaseDate = DateTime.Parse("2015-5-15"),
                 Genre = "FPS",
                 HoursToBeat = 6.00M,
                 Rating = "18"
             },

             new Game
             {
                 Title = "Infamous Second Son",
                 Company = "Sucker Punch",
                 ReleaseDate = DateTime.Parse("2014-3-21"),
                 Genre = "Action-Adventure",
                 HoursToBeat = 10.00M,
                 Rating = "16"
             },

             new Game
             {
                 Title = "Infamous First Light",
                Company = "Sucker Punch",
                ReleaseDate = DateTime.Parse("2014-8-27"),
                Genre = "Action-Adventure",
                HoursToBeat = 4.00M,
                 Rating = "16"
             });
        }
    }
}
