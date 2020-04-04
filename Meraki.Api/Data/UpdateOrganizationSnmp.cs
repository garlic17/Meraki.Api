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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationSnmp
	/// </summary>
	[DataContract]
    public partial class UpdateOrganizationSnmp :  IEquatable<UpdateOrganizationSnmp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationSnmp" /> class.
        /// </summary>
        /// <param name="V2cEnabled">Boolean indicating whether SNMP version 2c is enabled for the organization..</param>
        /// <param name="V3Enabled">Boolean indicating whether SNMP version 3 is enabled for the organization..</param>
        /// <param name="V3AuthMode">V3AuthMode.</param>
        /// <param name="V3AuthPass">The SNMP version 3 authentication password. Must be at least 8 characters if specified..</param>
        /// <param name="V3PrivMode">V3PrivMode.</param>
        /// <param name="V3PrivPass">The SNMP version 3 privacy password. Must be at least 8 characters if specified..</param>
        /// <param name="PeerIps">The IPs that are allowed to access the SNMP server. This list should be IPv4 addresses separated by semi-colons (ie. \&quot;1.2.3.4;2.3.4.5\&quot;)..</param>
        public UpdateOrganizationSnmp(bool? V2cEnabled = default, bool? V3Enabled = default, V3AuthMode V3AuthMode = default, string V3AuthPass = default, V3PrivMode V3PrivMode = default, string V3PrivPass = default, string PeerIps = default)
        {
            this.V2cEnabled = V2cEnabled;
            this.V3Enabled = V3Enabled;
            this.V3AuthMode = V3AuthMode;
            this.V3AuthPass = V3AuthPass;
            this.V3PrivMode = V3PrivMode;
            this.V3PrivPass = V3PrivPass;
            this.PeerIps = PeerIps;
        }

        /// <summary>
        /// Boolean indicating whether SNMP version 2c is enabled for the organization.
        /// </summary>
        /// <value>Boolean indicating whether SNMP version 2c is enabled for the organization.</value>
        [DataMember(Name="v2cEnabled", EmitDefaultValue=false)]
        public bool? V2cEnabled { get; set; }
        /// <summary>
        /// Boolean indicating whether SNMP version 3 is enabled for the organization.
        /// </summary>
        /// <value>Boolean indicating whether SNMP version 3 is enabled for the organization.</value>
        [DataMember(Name="v3Enabled", EmitDefaultValue=false)]
        public bool? V3Enabled { get; set; }
        /// <summary>
        /// Gets or Sets V3AuthMode
        /// </summary>
        [DataMember(Name="v3AuthMode", EmitDefaultValue=false)]
        public V3AuthMode V3AuthMode { get; set; }
        /// <summary>
        /// The SNMP version 3 authentication password. Must be at least 8 characters if specified.
        /// </summary>
        /// <value>The SNMP version 3 authentication password. Must be at least 8 characters if specified.</value>
        [DataMember(Name="v3AuthPass", EmitDefaultValue=false)]
        public string V3AuthPass { get; set; }
        /// <summary>
        /// Gets or Sets V3PrivMode
        /// </summary>
        [DataMember(Name="v3PrivMode", EmitDefaultValue=false)]
        public V3PrivMode V3PrivMode { get; set; }
        /// <summary>
        /// The SNMP version 3 privacy password. Must be at least 8 characters if specified.
        /// </summary>
        /// <value>The SNMP version 3 privacy password. Must be at least 8 characters if specified.</value>
        [DataMember(Name="v3PrivPass", EmitDefaultValue=false)]
        public string V3PrivPass { get; set; }
        /// <summary>
        /// The IPs that are allowed to access the SNMP server. This list should be IPv4 addresses separated by semi-colons (ie. \&quot;1.2.3.4;2.3.4.5\&quot;).
        /// </summary>
        /// <value>The IPs that are allowed to access the SNMP server. This list should be IPv4 addresses separated by semi-colons (ie. \&quot;1.2.3.4;2.3.4.5\&quot;).</value>
        [DataMember(Name="peerIps", EmitDefaultValue=false)]
        public string PeerIps { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationSnmp {\n");
            sb.Append("  V2cEnabled: ").Append(V2cEnabled).Append("\n");
            sb.Append("  V3Enabled: ").Append(V3Enabled).Append("\n");
            sb.Append("  V3AuthMode: ").Append(V3AuthMode).Append("\n");
            sb.Append("  V3AuthPass: ").Append(V3AuthPass).Append("\n");
            sb.Append("  V3PrivMode: ").Append(V3PrivMode).Append("\n");
            sb.Append("  V3PrivPass: ").Append(V3PrivPass).Append("\n");
            sb.Append("  PeerIps: ").Append(PeerIps).Append("\n");
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
            return Equals(obj as UpdateOrganizationSnmp);
        }

        /// <summary>
        /// Returns true if UpdateOrganizationSnmp instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateOrganizationSnmp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrganizationSnmp other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  V2cEnabled == other.V2cEnabled ||
						  (V2cEnabled != null &&
						  V2cEnabled.Equals(other.V2cEnabled))
					 ) &&
					 (
						  V3Enabled == other.V3Enabled ||
						  (V3Enabled != null &&
						  V3Enabled.Equals(other.V3Enabled))
					 ) &&
					 (
						  V3AuthMode == other.V3AuthMode ||
						  (V3AuthMode != null &&
						  V3AuthMode.Equals(other.V3AuthMode))
					 ) &&
					 (
						  V3AuthPass == other.V3AuthPass ||
						  (V3AuthPass != null &&
						  V3AuthPass.Equals(other.V3AuthPass))
					 ) &&
					 (
						  V3PrivMode == other.V3PrivMode ||
						  (V3PrivMode != null &&
						  V3PrivMode.Equals(other.V3PrivMode))
					 ) &&
					 (
						  V3PrivPass == other.V3PrivPass ||
						  (V3PrivPass != null &&
						  V3PrivPass.Equals(other.V3PrivPass))
					 ) &&
					 (
						  PeerIps == other.PeerIps ||
						  (PeerIps != null &&
						  PeerIps.Equals(other.PeerIps))
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
                if (V2cEnabled != null)
				{
					hash = (hash * 59) + V2cEnabled.GetHashCode();
				}

				if (V3Enabled != null)
				{
					hash = (hash * 59) + V3Enabled.GetHashCode();
				}

				if (V3AuthMode != null)
				{
					hash = (hash * 59) + V3AuthMode.GetHashCode();
				}

				if (V3AuthPass != null)
				{
					hash = (hash * 59) + V3AuthPass.GetHashCode();
				}

				if (V3PrivMode != null)
				{
					hash = (hash * 59) + V3PrivMode.GetHashCode();
				}

				if (V3PrivPass != null)
				{
					hash = (hash * 59) + V3PrivPass.GetHashCode();
				}

				if (PeerIps != null)
				{
					hash = (hash * 59) + PeerIps.GetHashCode();
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
