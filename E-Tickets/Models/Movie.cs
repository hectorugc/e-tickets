using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using E_Tickets.Data;

namespace E_Tickets.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public double Price { get; set; }
        [Display(Name = "Image")]

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }


        //Cinema 

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }


        //Producer

        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]

        public Producer Producer { get; set; }

    }
}
