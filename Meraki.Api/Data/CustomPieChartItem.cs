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
	/// CustomPieChartItem
	/// </summary>
	[DataContract]
    public partial class CustomPieChartItem :  IEquatable<CustomPieChartItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPieChartItem" /> class.
        /// </summary>
        [JsonConstructor]
        protected CustomPieChartItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPieChartItem" /> class.
        /// </summary>
        /// <param name="Name">The name of the custom pie chart item. (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="Value">The value of the custom pie chart item. Valid syntax depends on the signature type of the chart item     (see sample request/response for more details). (required).</param>
        public CustomPieChartItem(string Name = default, Type8 Type = default, string Value = default)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CustomPieChartItem and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for CustomPieChartItem and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for CustomPieChartItem and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
        }

        /// <summary>
        /// The name of the custom pie chart item.
        /// </summary>
        /// <value>The name of the custom pie chart item.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public Type8 Type { get; set; }
        /// <summary>
        /// The value of the custom pie chart item. Valid syntax depends on the signature type of the chart item     (see sample request/response for more details).
        /// </summary>
        /// <value>The value of the custom pie chart item. Valid syntax depends on the signature type of the chart item     (see sample request/response for more details).</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomPieChartItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(obj as CustomPieChartItem);
        }

        /// <summary>
        /// Returns true if CustomPieChartItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomPieChartItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomPieChartItem other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Name == other.Name ||
						  (Name != null &&
						  Name.Equals(other.Name))
					 ) &&
					 (
						  Type == other.Type ||
						  (Type != null &&
						  Type.Equals(other.Type))
					 ) &&
					 (
						  Value == other.Value ||
						  (Value != null &&
						  Value.Equals(other.Value))
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
                if (Name != null)
				{
					hash = (hash * 59) + Name.GetHashCode();
				}

				if (Type != null)
				{
					hash = (hash * 59) + Type.GetHashCode();
				}

				if (Value != null)
				{
					hash = (hash * 59) + Value.GetHashCode();
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
