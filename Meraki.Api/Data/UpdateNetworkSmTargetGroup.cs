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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSmTargetGroup
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSmTargetGroup :  IEquatable<UpdateNetworkSmTargetGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSmTargetGroup" /> class.
        /// </summary>
        /// <param name="Name">The name of this target group.</param>
        /// <param name="Scope">The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty..</param>
        public UpdateNetworkSmTargetGroup(string Name = default, string Scope = default)
        {
            this.Name = Name;
            this.Scope = Scope;
        }

        /// <summary>
        /// The name of this target group
        /// </summary>
        /// <value>The name of this target group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.
        /// </summary>
        /// <value>The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSmTargetGroup {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return Equals(obj as UpdateNetworkSmTargetGroup);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSmTargetGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSmTargetGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSmTargetGroup other)
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
						  Scope == other.Scope ||
						  (Scope != null &&
						  Scope.Equals(other.Scope))
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

				if (Scope != null)
				{
					hash = (hash * 59) + Scope.GetHashCode();
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
