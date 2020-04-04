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
	/// Server
	/// </summary>
	[DataContract]
    public partial class Server :  IEquatable<Server>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        [JsonConstructor]
        protected Server() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        /// <param name="Host">The IP address of the syslog server (required).</param>
        /// <param name="Port">The port of the syslog server (required).</param>
        /// <param name="Roles">A list of roles for the syslog server. Options (case-insensitive): &#39;Wireless event log&#39;, &#39;Appliance event log&#39;, &#39;Switch event log&#39;, &#39;Air Marshal events&#39;, &#39;Flows&#39;, &#39;URLs&#39;, &#39;IDS alerts&#39;, &#39;Security events&#39; (required).</param>
        public Server(string Host = default, int? Port = default, List<string> Roles = default)
        {
            // to ensure "Host" is required (not null)
            if (Host == null)
            {
                throw new InvalidDataException("Host is a required property for Server and cannot be null");
            }
            else
            {
                this.Host = Host;
            }
            // to ensure "Port" is required (not null)
            if (Port == null)
            {
                throw new InvalidDataException("Port is a required property for Server and cannot be null");
            }
            else
            {
                this.Port = Port;
            }
            // to ensure "Roles" is required (not null)
            if (Roles == null)
            {
                throw new InvalidDataException("Roles is a required property for Server and cannot be null");
            }
            else
            {
                this.Roles = Roles;
            }
        }

        /// <summary>
        /// The IP address of the syslog server
        /// </summary>
        /// <value>The IP address of the syslog server</value>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }
        /// <summary>
        /// The port of the syslog server
        /// </summary>
        /// <value>The port of the syslog server</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }
        /// <summary>
        /// A list of roles for the syslog server. Options (case-insensitive): &#39;Wireless event log&#39;, &#39;Appliance event log&#39;, &#39;Switch event log&#39;, &#39;Air Marshal events&#39;, &#39;Flows&#39;, &#39;URLs&#39;, &#39;IDS alerts&#39;, &#39;Security events&#39;
        /// </summary>
        /// <value>A list of roles for the syslog server. Options (case-insensitive): &#39;Wireless event log&#39;, &#39;Appliance event log&#39;, &#39;Switch event log&#39;, &#39;Air Marshal events&#39;, &#39;Flows&#39;, &#39;URLs&#39;, &#39;IDS alerts&#39;, &#39;Security events&#39;</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Server {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return Equals(obj as Server);
        }

        /// <summary>
        /// Returns true if Server instances are equal
        /// </summary>
        /// <param name="other">Instance of Server to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Server other)
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
						  Roles == other.Roles ||
						  (Roles != null &&
						  Roles.SequenceEqual(other.Roles))
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

				if (Roles != null)
				{
					hash = (hash * 59) + Roles.GetHashCode();
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
