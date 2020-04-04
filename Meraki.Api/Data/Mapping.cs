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
	/// Mapping
	/// </summary>
	[DataContract]
    public partial class Mapping :  IEquatable<Mapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mapping" /> class.
        /// </summary>
        [JsonConstructor]
        protected Mapping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mapping" /> class.
        /// </summary>
        /// <param name="Dscp">The Differentiated Services Code Point (DSCP) tag in the IP header that will be mapped to a particular Class-of-Service (CoS) queue. Value can be in the range of 0 to 63 inclusive. (required).</param>
        /// <param name="Cos">The actual layer-2 CoS queue the DSCP value is mapped to. These are not bits set on outgoing frames. Value can be in the range of 0 to 5 inclusive. (required).</param>
        /// <param name="Title">Label for the mapping (optional)..</param>
        public Mapping(int? Dscp = default, int? Cos = default, string Title = default)
        {
            // to ensure "Dscp" is required (not null)
            if (Dscp == null)
            {
                throw new InvalidDataException("Dscp is a required property for Mapping and cannot be null");
            }
            else
            {
                this.Dscp = Dscp;
            }
            // to ensure "Cos" is required (not null)
            if (Cos == null)
            {
                throw new InvalidDataException("Cos is a required property for Mapping and cannot be null");
            }
            else
            {
                this.Cos = Cos;
            }
            this.Title = Title;
        }

        /// <summary>
        /// The Differentiated Services Code Point (DSCP) tag in the IP header that will be mapped to a particular Class-of-Service (CoS) queue. Value can be in the range of 0 to 63 inclusive.
        /// </summary>
        /// <value>The Differentiated Services Code Point (DSCP) tag in the IP header that will be mapped to a particular Class-of-Service (CoS) queue. Value can be in the range of 0 to 63 inclusive.</value>
        [DataMember(Name="dscp", EmitDefaultValue=false)]
        public int? Dscp { get; set; }
        /// <summary>
        /// The actual layer-2 CoS queue the DSCP value is mapped to. These are not bits set on outgoing frames. Value can be in the range of 0 to 5 inclusive.
        /// </summary>
        /// <value>The actual layer-2 CoS queue the DSCP value is mapped to. These are not bits set on outgoing frames. Value can be in the range of 0 to 5 inclusive.</value>
        [DataMember(Name="cos", EmitDefaultValue=false)]
        public int? Cos { get; set; }
        /// <summary>
        /// Label for the mapping (optional).
        /// </summary>
        /// <value>Label for the mapping (optional).</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mapping {\n");
            sb.Append("  Dscp: ").Append(Dscp).Append("\n");
            sb.Append("  Cos: ").Append(Cos).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return Equals(obj as Mapping);
        }

        /// <summary>
        /// Returns true if Mapping instances are equal
        /// </summary>
        /// <param name="other">Instance of Mapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mapping other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Dscp == other.Dscp ||
						  (Dscp != null &&
						  Dscp.Equals(other.Dscp))
					 ) &&
					 (
						  Cos == other.Cos ||
						  (Cos != null &&
						  Cos.Equals(other.Cos))
					 ) &&
					 (
						  Title == other.Title ||
						  (Title != null &&
						  Title.Equals(other.Title))
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
                if (Dscp != null)
				{
					hash = (hash * 59) + Dscp.GetHashCode();
				}

				if (Cos != null)
				{
					hash = (hash * 59) + Cos.GetHashCode();
				}

				if (Title != null)
				{
					hash = (hash * 59) + Title.GetHashCode();
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
