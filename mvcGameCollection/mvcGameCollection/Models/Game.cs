using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcGameCollection.Models
{
    public class Game
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }


        [Display(Name = "Developer")]
        public string Company { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Display(Name = "Hours To Beat")]
        public decimal HoursToBeat { get; set; }

        [Display(Name = "Box Art")]
        public string Rating { get; set; }
    }

    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}