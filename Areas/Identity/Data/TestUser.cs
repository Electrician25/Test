﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Test.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TestUser class
public class TestUser : IdentityUser
{
	public int? UserId { get; set; }
	public string? Email { get; set; }
	public string? UserPassword { get; set; }

	public ContactStatus Status { get; set; }

	public enum ContactStatus
	{
		Submitted,
		Approved,
		Rejected
	}
}