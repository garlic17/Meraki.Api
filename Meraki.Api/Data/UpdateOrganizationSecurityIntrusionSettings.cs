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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationSecurityIntrusionSettings
	/// </summary>
	[DataContract]
    public partial class UpdateOrganizationSecurityIntrusionSettings :  IEquatable<UpdateOrganizationSecurityIntrusionSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationSecurityIntrusionSettings" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateOrganizationSecurityIntrusionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationSecurityIntrusionSettings" /> class.
        /// </summary>
        /// <param name="WhitelistedRules">Sets a list of specific SNORT® signatures to whitelist (required).</param>
        public UpdateOrganizationSecurityIntrusionSettings(List<WhitelistedRule> WhitelistedRules = default)
        {
            // to ensure "WhitelistedRules" is required (not null)
            if (WhitelistedRules == null)
            {
                throw new InvalidDataException("WhitelistedRules is a required property for UpdateOrganizationSecurityIntrusionSettings and cannot be null");
            }
            else
            {
                this.WhitelistedRules = WhitelistedRules;
            }
        }

        /// <summary>
        /// Sets a list of specific SNORT® signatures to whitelist
        /// </summary>
        /// <value>Sets a list of specific SNORT® signatures to whitelist</value>
        [DataMember(Name="whitelistedRules", EmitDefaultValue=false)]
        public List<WhitelistedRule> WhitelistedRules { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationSecurityIntrusionSettings {\n");
            sb.Append("  WhitelistedRules: ").Append(WhitelistedRules).Append("\n");
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
            return Equals(obj as UpdateOrganizationSecurityIntrusionSettings);
        }

        /// <summary>
        /// Returns true if UpdateOrganizationSecurityIntrusionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateOrganizationSecurityIntrusionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrganizationSecurityIntrusionSettings other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: WhitelistedRules == other.WhitelistedRules ||
						  (WhitelistedRules != null &&
						  WhitelistedRules.SequenceEqual(other.WhitelistedRules));
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
                if (WhitelistedRules != null)
				{
					hash = (hash * 59) + WhitelistedRules.GetHashCode();
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
