using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MagasinVideo.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }

    }
}