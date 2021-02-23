using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentAToyota2023.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Model name is required.")]
        [StringLength(30, ErrorMessage = "Model name cannot be more than 30 characters.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "You have to choose a color.")]
        [StringLength(30, ErrorMessage = "Color cannot be more than 30 characters.")]

        public string Color { get; set; }

        [Required(ErrorMessage = "You have to choose a price.")]

        public int Price { get; set; }
        public Car()
        {

        }
    }
}
