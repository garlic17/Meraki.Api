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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Quality and resolution for MV22X/MV72X camera models.
	/// </summary>
	[DataContract]
    public partial class MV22XMV72X :  IEquatable<MV22XMV72X>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MV22XMV72X" /> class.
        /// </summary>
        [JsonConstructor]
        protected MV22XMV72X() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MV22XMV72X" /> class.
        /// </summary>
        /// <param name="Quality">Quality (required).</param>
        /// <param name="Resolution">Resolution (required).</param>
        public MV22XMV72X(Quality1 Quality = default, Resolution4 Resolution = default)
        {
            // to ensure "Quality" is required (not null)
            if (Quality == null)
            {
                throw new InvalidDataException("Quality is a required property for MV22XMV72X and cannot be null");
            }
            else
            {
                this.Quality = Quality;
            }
            // to ensure "Resolution" is required (not null)
            if (Resolution == null)
            {
                throw new InvalidDataException("Resolution is a required property for MV22XMV72X and cannot be null");
            }
            else
            {
                this.Resolution = Resolution;
            }
        }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public Quality1 Quality { get; set; }
        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public Resolution4 Resolution { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MV22XMV72X {\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
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
            return Equals(obj as MV22XMV72X);
        }

        /// <summary>
        /// Returns true if MV22XMV72X instances are equal
        /// </summary>
        /// <param name="other">Instance of MV22XMV72X to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MV22XMV72X other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Quality == other.Quality ||
						  (Quality != null &&
						  Quality.Equals(other.Quality))
					 ) &&
					 (
						  Resolution == other.Resolution ||
						  (Resolution != null &&
						  Resolution.Equals(other.Resolution))
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
                if (Quality != null)
				{
					hash = (hash * 59) + Quality.GetHashCode();
				}

				if (Resolution != null)
				{
					hash = (hash * 59) + Resolution.GetHashCode();
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
