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
	/// CreateNetworkSmAppPolaris
	/// </summary>
	[DataContract]
    public partial class CreateNetworkSmAppPolaris :  IEquatable<CreateNetworkSmAppPolaris>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNetworkSmAppPolaris" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateNetworkSmAppPolaris() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNetworkSmAppPolaris" /> class.
        /// </summary>
        /// <param name="Scope">The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned (required).</param>
        /// <param name="ManifestUrl">The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided).</param>
        /// <param name="BundleId">The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided).</param>
        /// <param name="PreventAutoInstall">(optional) Whether or not SM should auto-install this app (one of true or false). False by default..</param>
        /// <param name="UsesVPP">(optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default..</param>
        public CreateNetworkSmAppPolaris(string Scope = default, string ManifestUrl = default, string BundleId = default, bool? PreventAutoInstall = default, bool? UsesVPP = default)
        {
            // to ensure "Scope" is required (not null)
            if (Scope == null)
            {
                throw new InvalidDataException("Scope is a required property for CreateNetworkSmAppPolaris and cannot be null");
            }
            else
            {
                this.Scope = Scope;
            }
            this.ManifestUrl = ManifestUrl;
            this.BundleId = BundleId;
            this.PreventAutoInstall = PreventAutoInstall;
            this.UsesVPP = UsesVPP;
        }

        /// <summary>
        /// The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned
        /// </summary>
        /// <value>The scope (one of all, none, automatic, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be assigned</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided)
        /// </summary>
        /// <value>The manifest URL of the Polaris app (one of manifestUrl and bundleId must be provided)</value>
        [DataMember(Name="manifestUrl", EmitDefaultValue=false)]
        public string ManifestUrl { get; set; }
        /// <summary>
        /// The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided)
        /// </summary>
        /// <value>The bundleId of the Polaris app (one of manifestUrl and bundleId must be provided)</value>
        [DataMember(Name="bundleId", EmitDefaultValue=false)]
        public string BundleId { get; set; }
        /// <summary>
        /// (optional) Whether or not SM should auto-install this app (one of true or false). False by default.
        /// </summary>
        /// <value>(optional) Whether or not SM should auto-install this app (one of true or false). False by default.</value>
        [DataMember(Name="preventAutoInstall", EmitDefaultValue=false)]
        public bool? PreventAutoInstall { get; set; }
        /// <summary>
        /// (optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default.
        /// </summary>
        /// <value>(optional) Whether or not the app should use VPP by device assignment (one of true or false). False by default.</value>
        [DataMember(Name="usesVPP", EmitDefaultValue=false)]
        public bool? UsesVPP { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNetworkSmAppPolaris {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ManifestUrl: ").Append(ManifestUrl).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  PreventAutoInstall: ").Append(PreventAutoInstall).Append("\n");
            sb.Append("  UsesVPP: ").Append(UsesVPP).Append("\n");
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
            return Equals(obj as CreateNetworkSmAppPolaris);
        }

        /// <summary>
        /// Returns true if CreateNetworkSmAppPolaris instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateNetworkSmAppPolaris to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNetworkSmAppPolaris other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Scope == other.Scope ||
						  (Scope != null &&
						  Scope.Equals(other.Scope))
					 ) &&
					 (
						  ManifestUrl == other.ManifestUrl ||
						  (ManifestUrl != null &&
						  ManifestUrl.Equals(other.ManifestUrl))
					 ) &&
					 (
						  BundleId == other.BundleId ||
						  (BundleId != null &&
						  BundleId.Equals(other.BundleId))
					 ) &&
					 (
						  PreventAutoInstall == other.PreventAutoInstall ||
						  (PreventAutoInstall != null &&
						  PreventAutoInstall.Equals(other.PreventAutoInstall))
					 ) &&
					 (
						  UsesVPP == other.UsesVPP ||
						  (UsesVPP != null &&
						  UsesVPP.Equals(other.UsesVPP))
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
                if (Scope != null)
				{
					hash = (hash * 59) + Scope.GetHashCode();
				}

				if (ManifestUrl != null)
				{
					hash = (hash * 59) + ManifestUrl.GetHashCode();
				}

				if (BundleId != null)
				{
					hash = (hash * 59) + BundleId.GetHashCode();
				}

				if (PreventAutoInstall != null)
				{
					hash = (hash * 59) + PreventAutoInstall.GetHashCode();
				}

				if (UsesVPP != null)
				{
					hash = (hash * 59) + UsesVPP.GetHashCode();
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
