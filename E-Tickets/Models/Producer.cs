using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using E_Tickets.Data.Base;

namespace E_Tickets.Models
{
    public class Producer : IEntityBase
    {
        public Producer()
        {
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture Url")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
