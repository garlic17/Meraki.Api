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
	/// Rule11
	/// </summary>
	[DataContract]
    public partial class Rule11 :  IEquatable<Rule11>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule11" /> class.
        /// </summary>
        [JsonConstructor]
        protected Rule11() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule11" /> class.
        /// </summary>
        /// <param name="Definitions">A list of objects describing the definitions of your traffic shaping rule. At least one definition is required. (required).</param>
        /// <param name="PerClientBandwidthLimits">PerClientBandwidthLimits.</param>
        /// <param name="DscpTagValue">The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint..</param>
        /// <param name="PcpTagValue">The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority).     null means &#39;Do not set PCP tag&#39;..</param>
        public Rule11(List<Definition> Definitions = default, PerClientBandwidthLimits PerClientBandwidthLimits = default, int? DscpTagValue = default, int? PcpTagValue = default)
        {
            // to ensure "Definitions" is required (not null)
            if (Definitions == null)
            {
                throw new InvalidDataException("Definitions is a required property for Rule11 and cannot be null");
            }
            else
            {
                this.Definitions = Definitions;
            }
            this.PerClientBandwidthLimits = PerClientBandwidthLimits;
            this.DscpTagValue = DscpTagValue;
            this.PcpTagValue = PcpTagValue;
        }

        /// <summary>
        /// A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.
        /// </summary>
        /// <value>A list of objects describing the definitions of your traffic shaping rule. At least one definition is required.</value>
        [DataMember(Name="definitions", EmitDefaultValue=false)]
        public List<Definition> Definitions { get; set; }
        /// <summary>
        /// Gets or Sets PerClientBandwidthLimits
        /// </summary>
        [DataMember(Name="perClientBandwidthLimits", EmitDefaultValue=false)]
        public PerClientBandwidthLimits PerClientBandwidthLimits { get; set; }
        /// <summary>
        /// The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.
        /// </summary>
        /// <value>The DSCP tag applied by your rule. null means &#39;Do not change DSCP tag&#39;.     For a list of possible tag values, use the trafficShaping/dscpTaggingOptions endpoint.</value>
        [DataMember(Name="dscpTagValue", EmitDefaultValue=false)]
        public int? DscpTagValue { get; set; }
        /// <summary>
        /// The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority).     null means &#39;Do not set PCP tag&#39;.
        /// </summary>
        /// <value>The PCP tag applied by your rule. Can be 0 (lowest priority) through 7 (highest priority).     null means &#39;Do not set PCP tag&#39;.</value>
        [DataMember(Name="pcpTagValue", EmitDefaultValue=false)]
        public int? PcpTagValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule11 {\n");
            sb.Append("  Definitions: ").Append(Definitions).Append("\n");
            sb.Append("  PerClientBandwidthLimits: ").Append(PerClientBandwidthLimits).Append("\n");
            sb.Append("  DscpTagValue: ").Append(DscpTagValue).Append("\n");
            sb.Append("  PcpTagValue: ").Append(PcpTagValue).Append("\n");
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
            return Equals(obj as Rule11);
        }

        /// <summary>
        /// Returns true if Rule11 instances are equal
        /// </summary>
        /// <param name="other">Instance of Rule11 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule11 other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Definitions == other.Definitions ||
						  (Definitions != null &&
						  Definitions.SequenceEqual(other.Definitions))
					 ) &&
					 (
						  PerClientBandwidthLimits == other.PerClientBandwidthLimits ||
						  (PerClientBandwidthLimits != null &&
						  PerClientBandwidthLimits.Equals(other.PerClientBandwidthLimits))
					 ) &&
					 (
						  DscpTagValue == other.DscpTagValue ||
						  (DscpTagValue != null &&
						  DscpTagValue.Equals(other.DscpTagValue))
					 ) &&
					 (
						  PcpTagValue == other.PcpTagValue ||
						  (PcpTagValue != null &&
						  PcpTagValue.Equals(other.PcpTagValue))
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
                if (Definitions != null)
				{
					hash = (hash * 59) + Definitions.GetHashCode();
				}

				if (PerClientBandwidthLimits != null)
				{
					hash = (hash * 59) + PerClientBandwidthLimits.GetHashCode();
				}

				if (DscpTagValue != null)
				{
					hash = (hash * 59) + DscpTagValue.GetHashCode();
				}

				if (PcpTagValue != null)
				{
					hash = (hash * 59) + PcpTagValue.GetHashCode();
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
