using AutoMapper;
using HotelListing.Data;
using HotelListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<ApiUser> _userManager;
		private readonly SignInManager<ApiUser> _signInManager;
		private readonly ILogger<AccountController> _logger;
		private readonly IMapper _mapper;

		public AccountController(UserManager<ApiUser> userManager, SignInManager<ApiUser> signInManager, ILogger<HotelController> logger, IMapper mapper)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = logger;
			_mapper = mapper;
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
		{
			_logger.LogInformation($"Registration attempt for {userDTO.Email}");
		}

	}
}
