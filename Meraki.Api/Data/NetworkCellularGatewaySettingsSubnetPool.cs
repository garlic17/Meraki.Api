using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCellularGatewaySettingsSubnetPool
	/// </summary>
	[DataContract]
	public class NetworkCellularGatewaySettingsSubnetPool
	{
		/// <summary>
		/// CIDR of the pool of subnets. Each MG in this network will automatically pick a subnet from this pool.
		/// </summary>
		/// <value>CIDR of the pool of subnets. Each MG in this network will automatically pick a subnet from this pool.</value>
		[DataMember(Name = "cidr")]
		public string Cidr { get; set; } = string.Empty;

		/// <summary>
		/// Mask used for the subnet of all MGs in  this network.
		/// </summary>
		/// <value>Mask used for the subnet of all MGs in  this network.</value>
		[DataMember(Name = "mask")]
		public int? Mask { get; set; }

		/// <summary>
		/// Subnets
		/// </summary>
		[DataMember(Name = "subnets")]
		public List<CellularGatewaySubnet> Subnets { get; set; } = new();
	}
}