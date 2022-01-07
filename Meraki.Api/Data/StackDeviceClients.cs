﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;
/// <summary>
/// Clients
/// </summary>
[DataContract]
public class StackDeviceClients
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public StackDeviceClientsCounts Counts { get; set; } = new();
}
