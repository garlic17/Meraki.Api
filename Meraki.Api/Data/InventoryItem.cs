﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	/// <summary>
	/// An inventory item
	/// </summary>
	public class InventoryItem : NamedItem
	{
		/// <summary>
		/// mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// networkId
		/// </summary>
		[DataMember(Name = "networkId")]
		public string? NetworkId { get; set; }

		/// <summary>
		/// model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;

		/// <summary>
		/// claimedAt
		/// </summary>
		[DataMember(Name = "claimedAt")]
		public string ClaimedAt { get; set; } = string.Empty;

		/// <summary>
		/// publicIp
		/// </summary>
		[DataMember(Name = "publicIp")]
		public string? PublicIp { get; set; }

		/// <summary>
		/// OrderNumber
		/// </summary>
		[DataMember(Name = "orderNumber")]
		public string? OrderNumber { get; set; }

		/// <summary>
		/// name
		/// </summary>
		[DataMember(Name = "licenseExpirationDate")]
		public string? LicenseExpirationDate { get; set; }

		/// <summary>
		/// The list of tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// ProductType
		/// </summary>
		[DataMember(Name = "productType")]
		public ProductType ProductType { get; set; }
	}
}