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
	/// RadiusAccountingServer
	/// </summary>
	[DataContract]
    public partial class RadiusAccountingServer :  IEquatable<RadiusAccountingServer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiusAccountingServer" /> class.
        /// </summary>
        [JsonConstructor]
        protected RadiusAccountingServer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiusAccountingServer" /> class.
        /// </summary>
        /// <param name="Host">IP address to which the APs will send RADIUS accounting messages (required).</param>
        /// <param name="Port">Port on the RADIUS server that is listening for accounting messages.</param>
        /// <param name="Secret">Shared key used to authenticate messages between the APs and RADIUS server (required).</param>
        public RadiusAccountingServer(string Host = default, int? Port = default, string Secret = default)
        {
            // to ensure "Host" is required (not null)
            if (Host == null)
            {
                throw new InvalidDataException("Host is a required property for RadiusAccountingServer and cannot be null");
            }
            else
            {
                this.Host = Host;
            }
            // to ensure "Secret" is required (not null)
            if (Secret == null)
            {
                throw new InvalidDataException("Secret is a required property for RadiusAccountingServer and cannot be null");
            }
            else
            {
                this.Secret = Secret;
            }
            this.Port = Port;
        }

        /// <summary>
        /// IP address to which the APs will send RADIUS accounting messages
        /// </summary>
        /// <value>IP address to which the APs will send RADIUS accounting messages</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }
        /// <summary>
        /// Port on the RADIUS server that is listening for accounting messages
        /// </summary>
        /// <value>Port on the RADIUS server that is listening for accounting messages</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }
        /// <summary>
        /// Shared key used to authenticate messages between the APs and RADIUS server
        /// </summary>
        /// <value>Shared key used to authenticate messages between the APs and RADIUS server</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiusAccountingServer {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
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
            return Equals(obj as RadiusAccountingServer);
        }

        /// <summary>
        /// Returns true if RadiusAccountingServer instances are equal
        /// </summary>
        /// <param name="other">Instance of RadiusAccountingServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadiusAccountingServer other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Host == other.Host ||
						  (Host != null &&
						  Host.Equals(other.Host))
					 ) &&
					 (
						  Port == other.Port ||
						  (Port != null &&
						  Port.Equals(other.Port))
					 ) &&
					 (
						  Secret == other.Secret ||
						  (Secret != null &&
						  Secret.Equals(other.Secret))
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
                if (Host != null)
				{
					hash = (hash * 59) + Host.GetHashCode();
				}

				if (Port != null)
				{
					hash = (hash * 59) + Port.GetHashCode();
				}

				if (Secret != null)
				{
					hash = (hash * 59) + Secret.GetHashCode();
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
