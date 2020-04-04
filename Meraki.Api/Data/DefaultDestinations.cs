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
	/// The network-wide destinations for all alerts on the network.
	/// </summary>
	[DataContract]
    public partial class DefaultDestinations :  IEquatable<DefaultDestinations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultDestinations" /> class.
        /// </summary>
        /// <param name="Emails">A list of emails that will recieve the alert(s)..</param>
        /// <param name="AllAdmins">If true, then all network admins will receive emails..</param>
        /// <param name="Snmp">If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network..</param>
        /// <param name="HttpServerIds">A list of HTTP server IDs to send a Webhook to.</param>
        public DefaultDestinations(List<string> Emails = default, bool? AllAdmins = default, bool? Snmp = default, List<string> HttpServerIds = default)
        {
            this.Emails = Emails;
            this.AllAdmins = AllAdmins;
            this.Snmp = Snmp;
            this.HttpServerIds = HttpServerIds;
        }

        /// <summary>
        /// A list of emails that will recieve the alert(s).
        /// </summary>
        /// <value>A list of emails that will recieve the alert(s).</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<string> Emails { get; set; }
        /// <summary>
        /// If true, then all network admins will receive emails.
        /// </summary>
        /// <value>If true, then all network admins will receive emails.</value>
        [DataMember(Name="allAdmins", EmitDefaultValue=false)]
        public bool? AllAdmins { get; set; }
        /// <summary>
        /// If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network.
        /// </summary>
        /// <value>If true, then an SNMP trap will be sent if there is an SNMP trap server configured for this network.</value>
        [DataMember(Name="snmp", EmitDefaultValue=false)]
        public bool? Snmp { get; set; }
        /// <summary>
        /// A list of HTTP server IDs to send a Webhook to
        /// </summary>
        /// <value>A list of HTTP server IDs to send a Webhook to</value>
        [DataMember(Name="httpServerIds", EmitDefaultValue=false)]
        public List<string> HttpServerIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultDestinations {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  AllAdmins: ").Append(AllAdmins).Append("\n");
            sb.Append("  Snmp: ").Append(Snmp).Append("\n");
            sb.Append("  HttpServerIds: ").Append(HttpServerIds).Append("\n");
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
            return Equals(obj as DefaultDestinations);
        }

        /// <summary>
        /// Returns true if DefaultDestinations instances are equal
        /// </summary>
        /// <param name="other">Instance of DefaultDestinations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultDestinations other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Emails == other.Emails ||
						  (Emails != null &&
						  Emails.SequenceEqual(other.Emails))
					 ) &&
					 (
						  AllAdmins == other.AllAdmins ||
						  (AllAdmins != null &&
						  AllAdmins.Equals(other.AllAdmins))
					 ) &&
					 (
						  Snmp == other.Snmp ||
						  (Snmp != null &&
						  Snmp.Equals(other.Snmp))
					 ) &&
					 (
						  HttpServerIds == other.HttpServerIds ||
						  (HttpServerIds != null &&
						  HttpServerIds.SequenceEqual(other.HttpServerIds))
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
                if (Emails != null)
				{
					hash = (hash * 59) + Emails.GetHashCode();
				}

				if (AllAdmins != null)
				{
					hash = (hash * 59) + AllAdmins.GetHashCode();
				}

				if (Snmp != null)
				{
					hash = (hash * 59) + Snmp.GetHashCode();
				}

				if (HttpServerIds != null)
				{
					hash = (hash * 59) + HttpServerIds.GetHashCode();
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
