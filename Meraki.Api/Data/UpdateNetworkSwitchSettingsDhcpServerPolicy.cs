/* 
 * Meraki Dashboard API
 *
 *   *Version 0.10.0*  The Cisco Meraki Dashboard API is a modern REST API based on the OpenAPI specification.  > Date: 01 April, 2020 > > [What's New](https://meraki.io/whats-new/)  - --  [API Documentation](https://meraki.io/api)  [Community Support](https://meraki.io/community)  [Meraki Homepage](https://www.meraki.com)     
 *
 * OpenAPI spec version: 0.10.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsDhcpServerPolicy
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSwitchSettingsDhcpServerPolicy :  IEquatable<UpdateNetworkSwitchSettingsDhcpServerPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSwitchSettingsDhcpServerPolicy" /> class.
        /// </summary>
        /// <param name="DefaultPolicy">DefaultPolicy.</param>
        /// <param name="AllowedServers">List the MAC addresses of DHCP servers to permit on the network. Applicable only if defaultPolicy is set to block. An empty array will clear the entries..</param>
        /// <param name="BlockedServers">List the MAC addresses of DHCP servers to block on the network. Applicable only if defaultPolicy is set to allow. An empty array will clear the entries..</param>
        public UpdateNetworkSwitchSettingsDhcpServerPolicy(DefaultPolicy DefaultPolicy = default, List<string> AllowedServers = default, List<string> BlockedServers = default)
        {
            this.DefaultPolicy = DefaultPolicy;
            this.AllowedServers = AllowedServers;
            this.BlockedServers = BlockedServers;
        }

        /// <summary>
        /// Gets or Sets DefaultPolicy
        /// </summary>
        [DataMember(Name="defaultPolicy", EmitDefaultValue=false)]
        public DefaultPolicy DefaultPolicy { get; set; }
        /// <summary>
        /// List the MAC addresses of DHCP servers to permit on the network. Applicable only if defaultPolicy is set to block. An empty array will clear the entries.
        /// </summary>
        /// <value>List the MAC addresses of DHCP servers to permit on the network. Applicable only if defaultPolicy is set to block. An empty array will clear the entries.</value>
        [DataMember(Name="allowedServers", EmitDefaultValue=false)]
        public List<string> AllowedServers { get; set; }
        /// <summary>
        /// List the MAC addresses of DHCP servers to block on the network. Applicable only if defaultPolicy is set to allow. An empty array will clear the entries.
        /// </summary>
        /// <value>List the MAC addresses of DHCP servers to block on the network. Applicable only if defaultPolicy is set to allow. An empty array will clear the entries.</value>
        [DataMember(Name="blockedServers", EmitDefaultValue=false)]
        public List<string> BlockedServers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSwitchSettingsDhcpServerPolicy {\n");
            sb.Append("  DefaultPolicy: ").Append(DefaultPolicy).Append("\n");
            sb.Append("  AllowedServers: ").Append(AllowedServers).Append("\n");
            sb.Append("  BlockedServers: ").Append(BlockedServers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as UpdateNetworkSwitchSettingsDhcpServerPolicy);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSwitchSettingsDhcpServerPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSwitchSettingsDhcpServerPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSwitchSettingsDhcpServerPolicy other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  DefaultPolicy == other.DefaultPolicy ||
						  (DefaultPolicy != null &&
						  DefaultPolicy.Equals(other.DefaultPolicy))
					 ) &&
					 (
						  AllowedServers == other.AllowedServers ||
						  (AllowedServers != null &&
						  AllowedServers.SequenceEqual(other.AllowedServers))
					 ) &&
					 (
						  BlockedServers == other.BlockedServers ||
						  (BlockedServers != null &&
						  BlockedServers.SequenceEqual(other.BlockedServers))
					 );
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (DefaultPolicy != null)
				{
					hash = (hash * 59) + DefaultPolicy.GetHashCode();
				}

				if (AllowedServers != null)
				{
					hash = (hash * 59) + AllowedServers.GetHashCode();
				}

				if (BlockedServers != null)
				{
					hash = (hash * 59) + BlockedServers.GetHashCode();
				}

				return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
