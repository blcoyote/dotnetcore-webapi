﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
	public class CountryDTO
	{
		public int Id { get; set; }

		[Required]
		[StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
		public string Name { get; set; }
		[Required]
		[StringLength(maximumLength:2, ErrorMessage = "ShortName length must be 2")]
		public string ShortName { get; set; }
		public IList<HotelDTO> Hotels { get; set; }
	}
	public class CreateCountryDTO
	{
		[Required]
		[StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
		public string Name { get; set; }
		[Required]
		[StringLength(maximumLength: 2, ErrorMessage = "ShortName length must be 2")]
		public string ShortName { get; set; }
	}
}
