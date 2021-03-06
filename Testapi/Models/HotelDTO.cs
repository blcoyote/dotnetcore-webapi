using HotelListing.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
	public class HotelDTO : CreateHotelDTO
	{
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }

    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Hotel Name Is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 25, ErrorMessage = "Hotel Address Name Is Too Long")]
        public string Address { get; set; }
        [Required]
        [Range(1,5)]
        public double Rating { get; set; }
        public int CountryId { get; set; }

    }
}
