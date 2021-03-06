using Microsoft.Extensions.DependencyInjection;
using HotelListing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HotelListing
{
	public static class ServiceExtensions
	{
		public static void ConfigureIdentity(this IServiceCollection services) {

			var builder = services.AddIdentityCore<ApiUser>(q => q.User.RequireUniqueEmail = true);

			builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
			builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
		
		}
	}
}
