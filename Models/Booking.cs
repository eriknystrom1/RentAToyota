using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAToyota2023.Models
{
    public class Booking
    {



        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(30, ErrorMessage = "Name cannot be more than 30 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(30, ErrorMessage = "Email cannot be more than 30 characters.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Model name is required.")]
        [StringLength(30, ErrorMessage = "Model name cannot be more than 30 characters.")]


        public string Model { get; set; }
        [Required(ErrorMessage = "You have to choose a starting date.")]

        public DateTime From { get; set; }

        [Required(ErrorMessage = "You have to choose an end date.")]

        public DateTime To { get; set; }

        [Required(ErrorMessage = "You have to choose a price.")]

        public int Price { get; set; }



        public Booking()
        {

        }
    }
}
