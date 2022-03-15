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
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Full Name  is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography  is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
