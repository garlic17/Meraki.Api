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
	/// The bandwidth settings for the &#39;cellular&#39; uplink
	/// </summary>
	[DataContract]
    public partial class Cellular :  IEquatable<Cellular>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cellular" /> class.
        /// </summary>
        /// <param name="LimitUp">The maximum upload limit (integer, in Kbps). null indicates no limit.</param>
        /// <param name="LimitDown">The maximum download limit (integer, in Kbps). null indicates no limit.</param>
        public Cellular(int? LimitUp = default, int? LimitDown = default)
        {
            this.LimitUp = LimitUp;
            this.LimitDown = LimitDown;
        }

        /// <summary>
        /// The maximum upload limit (integer, in Kbps). null indicates no limit
        /// </summary>
        /// <value>The maximum upload limit (integer, in Kbps). null indicates no limit</value>
        [DataMember(Name="limitUp", EmitDefaultValue=false)]
        public int? LimitUp { get; set; }
        /// <summary>
        /// The maximum download limit (integer, in Kbps). null indicates no limit
        /// </summary>
        /// <value>The maximum download limit (integer, in Kbps). null indicates no limit</value>
        [DataMember(Name="limitDown", EmitDefaultValue=false)]
        public int? LimitDown { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cellular {\n");
            sb.Append("  LimitUp: ").Append(LimitUp).Append("\n");
            sb.Append("  LimitDown: ").Append(LimitDown).Append("\n");
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
            return Equals(obj as Cellular);
        }

        /// <summary>
        /// Returns true if Cellular instances are equal
        /// </summary>
        /// <param name="other">Instance of Cellular to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cellular other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  LimitUp == other.LimitUp ||
						  (LimitUp != null &&
						  LimitUp.Equals(other.LimitUp))
					 ) &&
					 (
						  LimitDown == other.LimitDown ||
						  (LimitDown != null &&
						  LimitDown.Equals(other.LimitDown))
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
                if (LimitUp != null)
				{
					hash = (hash * 59) + LimitUp.GetHashCode();
				}

				if (LimitDown != null)
				{
					hash = (hash * 59) + LimitDown.GetHashCode();
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
