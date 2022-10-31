﻿namespace Meraki.Api.Data;

/// <summary>
/// Organization management details
/// </summary>
[DataContract]
public class OrganizationManagement
{
	/// <summary>
	/// Details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "details")]
	public List<string> Details { get; set; } = new();
}
