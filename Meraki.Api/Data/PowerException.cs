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
	/// PowerException
	/// </summary>
	[DataContract]
    public partial class PowerException :  IEquatable<PowerException>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerException" /> class.
        /// </summary>
        [JsonConstructor]
        protected PowerException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerException" /> class.
        /// </summary>
        /// <param name="Serial">Serial number of the switch (required).</param>
        /// <param name="PowerType">PowerType (required).</param>
        public PowerException(string Serial = default, PowerType PowerType = default)
        {
            // to ensure "Serial" is required (not null)
            if (Serial == null)
            {
                throw new InvalidDataException("Serial is a required property for PowerException and cannot be null");
            }
            else
            {
                this.Serial = Serial;
            }
            // to ensure "PowerType" is required (not null)
            if (PowerType == null)
            {
                throw new InvalidDataException("PowerType is a required property for PowerException and cannot be null");
            }
            else
            {
                this.PowerType = PowerType;
            }
        }

        /// <summary>
        /// Serial number of the switch
        /// </summary>
        /// <value>Serial number of the switch</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }
        /// <summary>
        /// Gets or Sets PowerType
        /// </summary>
        [DataMember(Name="powerType", EmitDefaultValue=false)]
        public PowerType PowerType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerException {\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  PowerType: ").Append(PowerType).Append("\n");
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
            return Equals(obj as PowerException);
        }

        /// <summary>
        /// Returns true if PowerException instances are equal
        /// </summary>
        /// <param name="other">Instance of PowerException to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerException other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Serial == other.Serial ||
						  (Serial != null &&
						  Serial.Equals(other.Serial))
					 ) &&
					 (
						  PowerType == other.PowerType ||
						  (PowerType != null &&
						  PowerType.Equals(other.PowerType))
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
                if (Serial != null)
				{
					hash = (hash * 59) + Serial.GetHashCode();
				}

				if (PowerType != null)
				{
					hash = (hash * 59) + PowerType.GetHashCode();
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
