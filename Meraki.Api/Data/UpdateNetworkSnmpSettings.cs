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
	/// UpdateNetworkSnmpSettings
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSnmpSettings :  IEquatable<UpdateNetworkSnmpSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSnmpSettings" /> class.
        /// </summary>
        /// <param name="Access">Access.</param>
        /// <param name="CommunityString">The SNMP community string. Only relevant if &#39;access&#39; is set to &#39;community&#39;..</param>
        /// <param name="Users">The list of SNMP users. Only relevant if &#39;access&#39; is set to &#39;users&#39;..</param>
        public UpdateNetworkSnmpSettings(SnmpAccess Access = default, string CommunityString = default, List<User> Users = default)
        {
            this.Access = Access;
            this.CommunityString = CommunityString;
            this.Users = Users;
        }

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public SnmpAccess Access { get; set; }
        /// <summary>
        /// The SNMP community string. Only relevant if &#39;access&#39; is set to &#39;community&#39;.
        /// </summary>
        /// <value>The SNMP community string. Only relevant if &#39;access&#39; is set to &#39;community&#39;.</value>
        [DataMember(Name="communityString", EmitDefaultValue=false)]
        public string CommunityString { get; set; }
        /// <summary>
        /// The list of SNMP users. Only relevant if &#39;access&#39; is set to &#39;users&#39;.
        /// </summary>
        /// <value>The list of SNMP users. Only relevant if &#39;access&#39; is set to &#39;users&#39;.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSnmpSettings {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  CommunityString: ").Append(CommunityString).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return Equals(obj as UpdateNetworkSnmpSettings);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSnmpSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSnmpSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSnmpSettings other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Access == other.Access ||
						  (Access != null &&
						  Access.Equals(other.Access))
					 ) &&
					 (
						  CommunityString == other.CommunityString ||
						  (CommunityString != null &&
						  CommunityString.Equals(other.CommunityString))
					 ) &&
					 (
						  Users == other.Users ||
						  (Users != null &&
						  Users.SequenceEqual(other.Users))
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
                if (Access != null)
				{
					hash = (hash * 59) + Access.GetHashCode();
				}

				if (CommunityString != null)
				{
					hash = (hash * 59) + CommunityString.GetHashCode();
				}

				if (Users != null)
				{
					hash = (hash * 59) + Users.GetHashCode();
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
