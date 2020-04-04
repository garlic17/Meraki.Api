/*
 * Meraki Dashboard API
 *
 *   *Version 0.10.0*  The Cisco Meraki Dashboard API is a modern REST API based on the OpenAPI specification.  > Date: 01 April, 2020 > > [What's New](https://meraki.io/whats-new/)  - --  [API Documentation](https://meraki.io/api)  [Community Support](https://meraki.io/community)  [Meraki Homepage](https://www.meraki.com)
 *
 * OpenAPI spec version: 0.10.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkDeviceManagementInterfaceSettings
	/// </summary>
	[DataContract]
	public partial class ManagementInterfaceSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Wan1
		/// </summary>
		[DataMember(Name = "wan1", EmitDefaultValue = false)]
		public Wan Wan1 { get; set; }
		/// <summary>
		/// Gets or Sets Wan2
		/// </summary>
		[DataMember(Name = "wan2", EmitDefaultValue = false)]
		public Wan Wan2 { get; set; }
	}
}
