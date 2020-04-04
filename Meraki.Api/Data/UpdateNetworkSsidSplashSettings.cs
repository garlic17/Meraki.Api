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
	/// UpdateNetworkSsidSplashSettings
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSsidSplashSettings :  IEquatable<UpdateNetworkSsidSplashSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSsidSplashSettings" /> class.
        /// </summary>
        /// <param name="SplashUrl">[optional] The custom splash URL of the click-through splash page. Note that the URL can be configured without necessarily being used. In order to enable the custom URL, see &#39;useSplashUrl&#39;.</param>
        /// <param name="UseSplashUrl">[optional] Boolean indicating whether the user will be redirected to the custom splash url. A custom splash URL must be set if this is true. Note that depending on your SSID&#39;s access control settings, it may not be possible to use the custom splash URL..</param>
        public UpdateNetworkSsidSplashSettings(string SplashUrl = default, bool? UseSplashUrl = default)
        {
            this.SplashUrl = SplashUrl;
            this.UseSplashUrl = UseSplashUrl;
        }

        /// <summary>
        /// [optional] The custom splash URL of the click-through splash page. Note that the URL can be configured without necessarily being used. In order to enable the custom URL, see &#39;useSplashUrl&#39;
        /// </summary>
        /// <value>[optional] The custom splash URL of the click-through splash page. Note that the URL can be configured without necessarily being used. In order to enable the custom URL, see &#39;useSplashUrl&#39;</value>
        [DataMember(Name="splashUrl", EmitDefaultValue=false)]
        public string SplashUrl { get; set; }
        /// <summary>
        /// [optional] Boolean indicating whether the user will be redirected to the custom splash url. A custom splash URL must be set if this is true. Note that depending on your SSID&#39;s access control settings, it may not be possible to use the custom splash URL.
        /// </summary>
        /// <value>[optional] Boolean indicating whether the user will be redirected to the custom splash url. A custom splash URL must be set if this is true. Note that depending on your SSID&#39;s access control settings, it may not be possible to use the custom splash URL.</value>
        [DataMember(Name="useSplashUrl", EmitDefaultValue=false)]
        public bool? UseSplashUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSsidSplashSettings {\n");
            sb.Append("  SplashUrl: ").Append(SplashUrl).Append("\n");
            sb.Append("  UseSplashUrl: ").Append(UseSplashUrl).Append("\n");
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
            return Equals(obj as UpdateNetworkSsidSplashSettings);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSsidSplashSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSsidSplashSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSsidSplashSettings other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  SplashUrl == other.SplashUrl ||
						  (SplashUrl != null &&
						  SplashUrl.Equals(other.SplashUrl))
					 ) &&
					 (
						  UseSplashUrl == other.UseSplashUrl ||
						  (UseSplashUrl != null &&
						  UseSplashUrl.Equals(other.UseSplashUrl))
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
                if (SplashUrl != null)
				{
					hash = (hash * 59) + SplashUrl.GetHashCode();
				}

				if (UseSplashUrl != null)
				{
					hash = (hash * 59) + UseSplashUrl.GetHashCode();
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
