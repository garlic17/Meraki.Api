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
	/// Rule12
	/// </summary>
	[DataContract]
    public partial class Rule12 :  IEquatable<Rule12>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule12" /> class.
        /// </summary>
        [JsonConstructor]
        protected Rule12() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule12" /> class.
        /// </summary>
        /// <param name="Comment">Description of the rule (optional)..</param>
        /// <param name="Policy">Policy (required).</param>
        /// <param name="IpVersion">IpVersion.</param>
        /// <param name="Protocol">Protocol (required).</param>
        /// <param name="SrcCidr">Source IP address (in IP or CIDR notation) or &#39;any&#39;. (required).</param>
        /// <param name="SrcPort">Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;..</param>
        /// <param name="DstCidr">Destination IP address (in IP or CIDR notation) or &#39;any&#39;. (required).</param>
        /// <param name="DstPort">Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;..</param>
        /// <param name="Vlan">Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;..</param>
        public Rule12(string Comment = default, Policy7 Policy = default, IpVersion IpVersion = default, Protocol7 Protocol = default, string SrcCidr = default, string SrcPort = default, string DstCidr = default, string DstPort = default, string Vlan = default)
        {
            // to ensure "Policy" is required (not null)
            if (Policy == null)
            {
                throw new InvalidDataException("Policy is a required property for Rule12 and cannot be null");
            }
            else
            {
                this.Policy = Policy;
            }
            // to ensure "Protocol" is required (not null)
            if (Protocol == null)
            {
                throw new InvalidDataException("Protocol is a required property for Rule12 and cannot be null");
            }
            else
            {
                this.Protocol = Protocol;
            }
            // to ensure "SrcCidr" is required (not null)
            if (SrcCidr == null)
            {
                throw new InvalidDataException("SrcCidr is a required property for Rule12 and cannot be null");
            }
            else
            {
                this.SrcCidr = SrcCidr;
            }
            // to ensure "DstCidr" is required (not null)
            if (DstCidr == null)
            {
                throw new InvalidDataException("DstCidr is a required property for Rule12 and cannot be null");
            }
            else
            {
                this.DstCidr = DstCidr;
            }
            this.Comment = Comment;
            this.IpVersion = IpVersion;
            this.SrcPort = SrcPort;
            this.DstPort = DstPort;
            this.Vlan = Vlan;
        }

        /// <summary>
        /// Description of the rule (optional).
        /// </summary>
        /// <value>Description of the rule (optional).</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public Policy7 Policy { get; set; }
        /// <summary>
        /// Gets or Sets IpVersion
        /// </summary>
        [DataMember(Name="ipVersion", EmitDefaultValue=false)]
        public IpVersion IpVersion { get; set; }
        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public Protocol7 Protocol { get; set; }
        /// <summary>
        /// Source IP address (in IP or CIDR notation) or &#39;any&#39;.
        /// </summary>
        /// <value>Source IP address (in IP or CIDR notation) or &#39;any&#39;.</value>
        [DataMember(Name="srcCidr", EmitDefaultValue=false)]
        public string SrcCidr { get; set; }
        /// <summary>
        /// Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.
        /// </summary>
        /// <value>Source port. Must be in the range  of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.</value>
        [DataMember(Name="srcPort", EmitDefaultValue=false)]
        public string SrcPort { get; set; }
        /// <summary>
        /// Destination IP address (in IP or CIDR notation) or &#39;any&#39;.
        /// </summary>
        /// <value>Destination IP address (in IP or CIDR notation) or &#39;any&#39;.</value>
        [DataMember(Name="dstCidr", EmitDefaultValue=false)]
        public string DstCidr { get; set; }
        /// <summary>
        /// Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.
        /// </summary>
        /// <value>Destination port. Must be in the range of 1-65535 or &#39;any&#39;. Default is &#39;any&#39;.</value>
        [DataMember(Name="dstPort", EmitDefaultValue=false)]
        public string DstPort { get; set; }
        /// <summary>
        /// Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;.
        /// </summary>
        /// <value>Incoming traffic VLAN. Must be in the range of 1-4095 or &#39;any&#39;. Default is &#39;any&#39;.</value>
        [DataMember(Name="vlan", EmitDefaultValue=false)]
        public string Vlan { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule12 {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  IpVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  SrcCidr: ").Append(SrcCidr).Append("\n");
            sb.Append("  SrcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  DstCidr: ").Append(DstCidr).Append("\n");
            sb.Append("  DstPort: ").Append(DstPort).Append("\n");
            sb.Append("  Vlan: ").Append(Vlan).Append("\n");
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
            return Equals(obj as Rule12);
        }

        /// <summary>
        /// Returns true if Rule12 instances are equal
        /// </summary>
        /// <param name="other">Instance of Rule12 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule12 other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Comment == other.Comment ||
						  (Comment != null &&
						  Comment.Equals(other.Comment))
					 ) &&
					 (
						  Policy == other.Policy ||
						  (Policy != null &&
						  Policy.Equals(other.Policy))
					 ) &&
					 (
						  IpVersion == other.IpVersion ||
						  (IpVersion != null &&
						  IpVersion.Equals(other.IpVersion))
					 ) &&
					 (
						  Protocol == other.Protocol ||
						  (Protocol != null &&
						  Protocol.Equals(other.Protocol))
					 ) &&
					 (
						  SrcCidr == other.SrcCidr ||
						  (SrcCidr != null &&
						  SrcCidr.Equals(other.SrcCidr))
					 ) &&
					 (
						  SrcPort == other.SrcPort ||
						  (SrcPort != null &&
						  SrcPort.Equals(other.SrcPort))
					 ) &&
					 (
						  DstCidr == other.DstCidr ||
						  (DstCidr != null &&
						  DstCidr.Equals(other.DstCidr))
					 ) &&
					 (
						  DstPort == other.DstPort ||
						  (DstPort != null &&
						  DstPort.Equals(other.DstPort))
					 ) &&
					 (
						  Vlan == other.Vlan ||
						  (Vlan != null &&
						  Vlan.Equals(other.Vlan))
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
                if (Comment != null)
				{
					hash = (hash * 59) + Comment.GetHashCode();
				}

				if (Policy != null)
				{
					hash = (hash * 59) + Policy.GetHashCode();
				}

				if (IpVersion != null)
				{
					hash = (hash * 59) + IpVersion.GetHashCode();
				}

				if (Protocol != null)
				{
					hash = (hash * 59) + Protocol.GetHashCode();
				}

				if (SrcCidr != null)
				{
					hash = (hash * 59) + SrcCidr.GetHashCode();
				}

				if (SrcPort != null)
				{
					hash = (hash * 59) + SrcPort.GetHashCode();
				}

				if (DstCidr != null)
				{
					hash = (hash * 59) + DstCidr.GetHashCode();
				}

				if (DstPort != null)
				{
					hash = (hash * 59) + DstPort.GetHashCode();
				}

				if (Vlan != null)
				{
					hash = (hash * 59) + Vlan.GetHashCode();
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
