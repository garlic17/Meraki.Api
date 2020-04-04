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
	/// UpdateNetworkTrafficAnalysisSettings
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkTrafficAnalysisSettings :  IEquatable<UpdateNetworkTrafficAnalysisSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkTrafficAnalysisSettings" /> class.
        /// </summary>
        /// <param name="Mode">Mode.</param>
        /// <param name="CustomPieChartItems">The list of items that make up the custom pie chart for traffic reporting..</param>
        public UpdateNetworkTrafficAnalysisSettings(Mode3 Mode = default, List<CustomPieChartItem> CustomPieChartItems = default)
        {
            this.Mode = Mode;
            this.CustomPieChartItems = CustomPieChartItems;
        }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public Mode3 Mode { get; set; }
        /// <summary>
        /// The list of items that make up the custom pie chart for traffic reporting.
        /// </summary>
        /// <value>The list of items that make up the custom pie chart for traffic reporting.</value>
        [DataMember(Name="customPieChartItems", EmitDefaultValue=false)]
        public List<CustomPieChartItem> CustomPieChartItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkTrafficAnalysisSettings {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  CustomPieChartItems: ").Append(CustomPieChartItems).Append("\n");
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
            return Equals(obj as UpdateNetworkTrafficAnalysisSettings);
        }

        /// <summary>
        /// Returns true if UpdateNetworkTrafficAnalysisSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkTrafficAnalysisSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkTrafficAnalysisSettings other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Mode == other.Mode ||
						  (Mode != null &&
						  Mode.Equals(other.Mode))
					 ) &&
					 (
						  CustomPieChartItems == other.CustomPieChartItems ||
						  (CustomPieChartItems != null &&
						  CustomPieChartItems.SequenceEqual(other.CustomPieChartItems))
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
                if (Mode != null)
				{
					hash = (hash * 59) + Mode.GetHashCode();
				}

				if (CustomPieChartItems != null)
				{
					hash = (hash * 59) + CustomPieChartItems.GetHashCode();
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
