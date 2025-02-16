﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S8_Hotels.API.Filters
{
	public class AllowOnlyRequireHttps : RequireHttpsAttribute
	{
		protected override void HandleNonHttpsRequest(AuthorizationFilterContext filterContext)
		{
			filterContext.Result = new StatusCodeResult(400);
		}
	}
}
