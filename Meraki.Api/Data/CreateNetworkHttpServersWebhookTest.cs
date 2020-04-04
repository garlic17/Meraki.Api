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
	/// CreateNetworkHttpServersWebhookTest
	/// </summary>
	[DataContract]
    public partial class CreateNetworkHttpServersWebhookTest :  IEquatable<CreateNetworkHttpServersWebhookTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNetworkHttpServersWebhookTest" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateNetworkHttpServersWebhookTest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNetworkHttpServersWebhookTest" /> class.
        /// </summary>
        /// <param name="Url">The URL where the test webhook will be sent (required).</param>
        public CreateNetworkHttpServersWebhookTest(string Url = default)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for CreateNetworkHttpServersWebhookTest and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
        }

        /// <summary>
        /// The URL where the test webhook will be sent
        /// </summary>
        /// <value>The URL where the test webhook will be sent</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNetworkHttpServersWebhookTest {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return Equals(obj as CreateNetworkHttpServersWebhookTest);
        }

        /// <summary>
        /// Returns true if CreateNetworkHttpServersWebhookTest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateNetworkHttpServersWebhookTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNetworkHttpServersWebhookTest other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: Url == other.Url ||
						  (Url != null &&
						  Url.Equals(other.Url));
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
                if (Url != null)
				{
					hash = (hash * 59) + Url.GetHashCode();
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
