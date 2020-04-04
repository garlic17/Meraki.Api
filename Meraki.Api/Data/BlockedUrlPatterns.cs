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
	/// Settings for blacklisted URL patterns
	/// </summary>
	[DataContract]
    public partial class BlockedUrlPatterns :  IEquatable<BlockedUrlPatterns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedUrlPatterns" /> class.
        /// </summary>
        /// <param name="Settings">Settings.</param>
        /// <param name="Patterns">A blacklist of URL patterns to block.</param>
        public BlockedUrlPatterns(Settings2 Settings = default, List<string> Patterns = default)
        {
            this.Settings = Settings;
            this.Patterns = Patterns;
        }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Settings2 Settings { get; set; }
        /// <summary>
        /// A blacklist of URL patterns to block
        /// </summary>
        /// <value>A blacklist of URL patterns to block</value>
        [DataMember(Name="patterns", EmitDefaultValue=false)]
        public List<string> Patterns { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockedUrlPatterns {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Patterns: ").Append(Patterns).Append("\n");
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
            return Equals(obj as BlockedUrlPatterns);
        }

        /// <summary>
        /// Returns true if BlockedUrlPatterns instances are equal
        /// </summary>
        /// <param name="other">Instance of BlockedUrlPatterns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockedUrlPatterns other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Settings == other.Settings ||
						  (Settings != null &&
						  Settings.Equals(other.Settings))
					 ) &&
					 (
						  Patterns == other.Patterns ||
						  (Patterns != null &&
						  Patterns.SequenceEqual(other.Patterns))
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
                if (Settings != null)
				{
					hash = (hash * 59) + Settings.GetHashCode();
				}

				if (Patterns != null)
				{
					hash = (hash * 59) + Patterns.GetHashCode();
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
