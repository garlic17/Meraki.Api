﻿namespace Meraki.Api.Data;

[DataContract]
public class DeviceStatusOverviewCounts
{
	/// <summary>
	/// Bystatus
	/// </summary>
	[DataMember(Name = "byStatus")]
	public DeviceStatusOverviewCountsByStatus ByStatus { get; set; } = new();
}
