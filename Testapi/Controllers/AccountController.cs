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

		private readonly ILogger<AccountController> _logger;
		private readonly IMapper _mapper;

		public AccountController(UserManager<ApiUser> userManager, ILogger<AccountController> logger, IMapper mapper)
		{
			_userManager = userManager;
			_logger = logger;
			_mapper = mapper;
		}

		[HttpPost]
		[Route("register")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
		{
			_logger.LogInformation($"Registration attempt for {userDTO.Email}");
			
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
				var user = _mapper.Map<ApiUser>(userDTO);
				user.UserName = userDTO.Email;
				var result = await _userManager.CreateAsync(user, userDTO.Password);

				if (!result.Succeeded)
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(error.Code, error.Description);
					}
					return BadRequest(ModelState);
				}
				await _userManager.AddToRolesAsync(user, userDTO.Roles);

				return Ok();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
				return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
			}

		}

//		[HttpPost]
//		[Route("login")]
//		[ProducesResponseType(StatusCodes.Status202OK)]
//		[ProducesResponseType(StatusCodes.Status401Unauthorized)]
//		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
//		public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUserDTO)
//		{
//			_logger.LogInformation($"Login attempt for {loginUserDTO.Email}");

//			if (!ModelState.IsValid)
//			{
//				return BadRequest(ModelState);
//			}
//			try
//			{
//				var result = await _signInManager.PasswordSignInAsync(loginUserDTO.Email, loginUserDTO.Password, isPersistent:false, false);
//;
//				if (!result.Succeeded)
//				{
//					return Unauthorized($"User Login attempt Failed");
//				}

//				return Accepted();
//			}
//			catch (Exception ex)
//			{
//				_logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
//				return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
//			}

//		}

	}
}
