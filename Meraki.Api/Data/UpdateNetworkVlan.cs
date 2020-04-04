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
	/// UpdateNetworkVlan
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkVlan :  IEquatable<UpdateNetworkVlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkVlan" /> class.
        /// </summary>
        /// <param name="Name">The name of the VLAN.</param>
        /// <param name="Subnet">The subnet of the VLAN.</param>
        /// <param name="ApplianceIp">The local IP of the appliance on the VLAN.</param>
        /// <param name="GroupPolicyId">The id of the desired group policy to apply to the VLAN.</param>
        /// <param name="VpnNatSubnet">The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN.</param>
        /// <param name="DhcpHandling">DhcpHandling.</param>
        /// <param name="DhcpRelayServerIps">The IPs of the DHCP servers that DHCP requests should be relayed to.</param>
        /// <param name="DhcpLeaseTime">DhcpLeaseTime.</param>
        /// <param name="DhcpBootOptionsEnabled">Use DHCP boot options specified in other properties.</param>
        /// <param name="DhcpBootNextServer">DHCP boot option to direct boot clients to the server to load the boot file from.</param>
        /// <param name="DhcpBootFilename">DHCP boot option for boot filename.</param>
        /// <param name="FixedIpAssignments">The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details..</param>
        /// <param name="ReservedIpRanges">The DHCP reserved IP ranges on the VLAN.</param>
        /// <param name="DnsNameservers">The DNS nameservers used for DHCP responses, either \&quot;upstream_dns\&quot;, \&quot;google_dns\&quot;, \&quot;opendns\&quot;, or a newline seperated string of IP addresses or domain names.</param>
        /// <param name="DhcpOptions">The list of DHCP options that will be included in DHCP responses. Each object in the list should have \&quot;code\&quot;, \&quot;type\&quot;, and \&quot;value\&quot; properties..</param>
        public UpdateNetworkVlan(string Name = default, string Subnet = default, string ApplianceIp = default, string GroupPolicyId = default, string VpnNatSubnet = default, DhcpHandling DhcpHandling = default, List<string> DhcpRelayServerIps = default, DhcpLeaseTime DhcpLeaseTime = default, bool? DhcpBootOptionsEnabled = default, string DhcpBootNextServer = default, string DhcpBootFilename = default, object FixedIpAssignments = default, List<ReservedIpRange1> ReservedIpRanges = default, string DnsNameservers = default, List<DhcpOption> DhcpOptions = default)
        {
            this.Name = Name;
            this.Subnet = Subnet;
            this.ApplianceIp = ApplianceIp;
            this.GroupPolicyId = GroupPolicyId;
            this.VpnNatSubnet = VpnNatSubnet;
            this.DhcpHandling = DhcpHandling;
            this.DhcpRelayServerIps = DhcpRelayServerIps;
            this.DhcpLeaseTime = DhcpLeaseTime;
            this.DhcpBootOptionsEnabled = DhcpBootOptionsEnabled;
            this.DhcpBootNextServer = DhcpBootNextServer;
            this.DhcpBootFilename = DhcpBootFilename;
            this.FixedIpAssignments = FixedIpAssignments;
            this.ReservedIpRanges = ReservedIpRanges;
            this.DnsNameservers = DnsNameservers;
            this.DhcpOptions = DhcpOptions;
        }

        /// <summary>
        /// The name of the VLAN
        /// </summary>
        /// <value>The name of the VLAN</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The subnet of the VLAN
        /// </summary>
        /// <value>The subnet of the VLAN</value>
        [DataMember(Name="subnet", EmitDefaultValue=false)]
        public string Subnet { get; set; }
        /// <summary>
        /// The local IP of the appliance on the VLAN
        /// </summary>
        /// <value>The local IP of the appliance on the VLAN</value>
        [DataMember(Name="applianceIp", EmitDefaultValue=false)]
        public string ApplianceIp { get; set; }
        /// <summary>
        /// The id of the desired group policy to apply to the VLAN
        /// </summary>
        /// <value>The id of the desired group policy to apply to the VLAN</value>
        [DataMember(Name="groupPolicyId", EmitDefaultValue=false)]
        public string GroupPolicyId { get; set; }
        /// <summary>
        /// The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN
        /// </summary>
        /// <value>The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN</value>
        [DataMember(Name="vpnNatSubnet", EmitDefaultValue=false)]
        public string VpnNatSubnet { get; set; }
        /// <summary>
        /// Gets or Sets DhcpHandling
        /// </summary>
        [DataMember(Name="dhcpHandling", EmitDefaultValue=false)]
        public DhcpHandling DhcpHandling { get; set; }
        /// <summary>
        /// The IPs of the DHCP servers that DHCP requests should be relayed to
        /// </summary>
        /// <value>The IPs of the DHCP servers that DHCP requests should be relayed to</value>
        [DataMember(Name="dhcpRelayServerIps", EmitDefaultValue=false)]
        public List<string> DhcpRelayServerIps { get; set; }
        /// <summary>
        /// Gets or Sets DhcpLeaseTime
        /// </summary>
        [DataMember(Name="dhcpLeaseTime", EmitDefaultValue=false)]
        public DhcpLeaseTime DhcpLeaseTime { get; set; }
        /// <summary>
        /// Use DHCP boot options specified in other properties
        /// </summary>
        /// <value>Use DHCP boot options specified in other properties</value>
        [DataMember(Name="dhcpBootOptionsEnabled", EmitDefaultValue=false)]
        public bool? DhcpBootOptionsEnabled { get; set; }
        /// <summary>
        /// DHCP boot option to direct boot clients to the server to load the boot file from
        /// </summary>
        /// <value>DHCP boot option to direct boot clients to the server to load the boot file from</value>
        [DataMember(Name="dhcpBootNextServer", EmitDefaultValue=false)]
        public string DhcpBootNextServer { get; set; }
        /// <summary>
        /// DHCP boot option for boot filename
        /// </summary>
        /// <value>DHCP boot option for boot filename</value>
        [DataMember(Name="dhcpBootFilename", EmitDefaultValue=false)]
        public string DhcpBootFilename { get; set; }
        /// <summary>
        /// The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.
        /// </summary>
        /// <value>The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.</value>
        [DataMember(Name="fixedIpAssignments", EmitDefaultValue=false)]
        public object FixedIpAssignments { get; set; }
        /// <summary>
        /// The DHCP reserved IP ranges on the VLAN
        /// </summary>
        /// <value>The DHCP reserved IP ranges on the VLAN</value>
        [DataMember(Name="reservedIpRanges", EmitDefaultValue=false)]
        public List<ReservedIpRange1> ReservedIpRanges { get; set; }
        /// <summary>
        /// The DNS nameservers used for DHCP responses, either \&quot;upstream_dns\&quot;, \&quot;google_dns\&quot;, \&quot;opendns\&quot;, or a newline seperated string of IP addresses or domain names
        /// </summary>
        /// <value>The DNS nameservers used for DHCP responses, either \&quot;upstream_dns\&quot;, \&quot;google_dns\&quot;, \&quot;opendns\&quot;, or a newline seperated string of IP addresses or domain names</value>
        [DataMember(Name="dnsNameservers", EmitDefaultValue=false)]
        public string DnsNameservers { get; set; }
        /// <summary>
        /// The list of DHCP options that will be included in DHCP responses. Each object in the list should have \&quot;code\&quot;, \&quot;type\&quot;, and \&quot;value\&quot; properties.
        /// </summary>
        /// <value>The list of DHCP options that will be included in DHCP responses. Each object in the list should have \&quot;code\&quot;, \&quot;type\&quot;, and \&quot;value\&quot; properties.</value>
        [DataMember(Name="dhcpOptions", EmitDefaultValue=false)]
        public List<DhcpOption> DhcpOptions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkVlan {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subnet: ").Append(Subnet).Append("\n");
            sb.Append("  ApplianceIp: ").Append(ApplianceIp).Append("\n");
            sb.Append("  GroupPolicyId: ").Append(GroupPolicyId).Append("\n");
            sb.Append("  VpnNatSubnet: ").Append(VpnNatSubnet).Append("\n");
            sb.Append("  DhcpHandling: ").Append(DhcpHandling).Append("\n");
            sb.Append("  DhcpRelayServerIps: ").Append(DhcpRelayServerIps).Append("\n");
            sb.Append("  DhcpLeaseTime: ").Append(DhcpLeaseTime).Append("\n");
            sb.Append("  DhcpBootOptionsEnabled: ").Append(DhcpBootOptionsEnabled).Append("\n");
            sb.Append("  DhcpBootNextServer: ").Append(DhcpBootNextServer).Append("\n");
            sb.Append("  DhcpBootFilename: ").Append(DhcpBootFilename).Append("\n");
            sb.Append("  FixedIpAssignments: ").Append(FixedIpAssignments).Append("\n");
            sb.Append("  ReservedIpRanges: ").Append(ReservedIpRanges).Append("\n");
            sb.Append("  DnsNameservers: ").Append(DnsNameservers).Append("\n");
            sb.Append("  DhcpOptions: ").Append(DhcpOptions).Append("\n");
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
            return Equals(obj as UpdateNetworkVlan);
        }

        /// <summary>
        /// Returns true if UpdateNetworkVlan instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkVlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkVlan other)
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
						  Subnet == other.Subnet ||
						  (Subnet != null &&
						  Subnet.Equals(other.Subnet))
					 ) &&
					 (
						  ApplianceIp == other.ApplianceIp ||
						  (ApplianceIp != null &&
						  ApplianceIp.Equals(other.ApplianceIp))
					 ) &&
					 (
						  GroupPolicyId == other.GroupPolicyId ||
						  (GroupPolicyId != null &&
						  GroupPolicyId.Equals(other.GroupPolicyId))
					 ) &&
					 (
						  VpnNatSubnet == other.VpnNatSubnet ||
						  (VpnNatSubnet != null &&
						  VpnNatSubnet.Equals(other.VpnNatSubnet))
					 ) &&
					 (
						  DhcpHandling == other.DhcpHandling ||
						  (DhcpHandling != null &&
						  DhcpHandling.Equals(other.DhcpHandling))
					 ) &&
					 (
						  DhcpRelayServerIps == other.DhcpRelayServerIps ||
						  (DhcpRelayServerIps != null &&
						  DhcpRelayServerIps.SequenceEqual(other.DhcpRelayServerIps))
					 ) &&
					 (
						  DhcpLeaseTime == other.DhcpLeaseTime ||
						  (DhcpLeaseTime != null &&
						  DhcpLeaseTime.Equals(other.DhcpLeaseTime))
					 ) &&
					 (
						  DhcpBootOptionsEnabled == other.DhcpBootOptionsEnabled ||
						  (DhcpBootOptionsEnabled != null &&
						  DhcpBootOptionsEnabled.Equals(other.DhcpBootOptionsEnabled))
					 ) &&
					 (
						  DhcpBootNextServer == other.DhcpBootNextServer ||
						  (DhcpBootNextServer != null &&
						  DhcpBootNextServer.Equals(other.DhcpBootNextServer))
					 ) &&
					 (
						  DhcpBootFilename == other.DhcpBootFilename ||
						  (DhcpBootFilename != null &&
						  DhcpBootFilename.Equals(other.DhcpBootFilename))
					 ) &&
					 (
						  FixedIpAssignments == other.FixedIpAssignments ||
						  (FixedIpAssignments != null &&
						  FixedIpAssignments.Equals(other.FixedIpAssignments))
					 ) &&
					 (
						  ReservedIpRanges == other.ReservedIpRanges ||
						  (ReservedIpRanges != null &&
						  ReservedIpRanges.SequenceEqual(other.ReservedIpRanges))
					 ) &&
					 (
						  DnsNameservers == other.DnsNameservers ||
						  (DnsNameservers != null &&
						  DnsNameservers.Equals(other.DnsNameservers))
					 ) &&
					 (
						  DhcpOptions == other.DhcpOptions ||
						  (DhcpOptions != null &&
						  DhcpOptions.SequenceEqual(other.DhcpOptions))
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

				if (Subnet != null)
				{
					hash = (hash * 59) + Subnet.GetHashCode();
				}

				if (ApplianceIp != null)
				{
					hash = (hash * 59) + ApplianceIp.GetHashCode();
				}

				if (GroupPolicyId != null)
				{
					hash = (hash * 59) + GroupPolicyId.GetHashCode();
				}

				if (VpnNatSubnet != null)
				{
					hash = (hash * 59) + VpnNatSubnet.GetHashCode();
				}

				if (DhcpHandling != null)
				{
					hash = (hash * 59) + DhcpHandling.GetHashCode();
				}

				if (DhcpRelayServerIps != null)
				{
					hash = (hash * 59) + DhcpRelayServerIps.GetHashCode();
				}

				if (DhcpLeaseTime != null)
				{
					hash = (hash * 59) + DhcpLeaseTime.GetHashCode();
				}

				if (DhcpBootOptionsEnabled != null)
				{
					hash = (hash * 59) + DhcpBootOptionsEnabled.GetHashCode();
				}

				if (DhcpBootNextServer != null)
				{
					hash = (hash * 59) + DhcpBootNextServer.GetHashCode();
				}

				if (DhcpBootFilename != null)
				{
					hash = (hash * 59) + DhcpBootFilename.GetHashCode();
				}

				if (FixedIpAssignments != null)
				{
					hash = (hash * 59) + FixedIpAssignments.GetHashCode();
				}

				if (ReservedIpRanges != null)
				{
					hash = (hash * 59) + ReservedIpRanges.GetHashCode();
				}

				if (DnsNameservers != null)
				{
					hash = (hash * 59) + DnsNameservers.GetHashCode();
				}

				if (DhcpOptions != null)
				{
					hash = (hash * 59) + DhcpOptions.GetHashCode();
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
