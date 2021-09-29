using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISmNetworkApnsCert
	{
		/// <summary>
		/// Get the organization's APNS certificate
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/sm/apnsCert")]
		Task<ApnsCert> GetOrganizationSmApnsCertAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);
	}
}