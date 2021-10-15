using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ICameraQualityRetentionProfiles
	{
		/// <summary>
		/// Creates new quality retention profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkCameraQualityRetentionProfile">Body for creating quality retention profile</param>
		[Post("/networks/{networkId}/camera/qualityRetentionProfiles")]
		Task<CameraQualityAndRetentionSettings> CreateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] CameraQualityAndRetentionProfileCreationRequest createNetworkCameraQualityRetentionProfile,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Delete an existing quality retention profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qualityRetentionProfileId">The quality retention profile id</param>
		[Delete("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qualityRetentionProfileId")] string qualityRetentionProfileId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Retrieve a single quality retention profile
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qualityRetentionProfileId">The quality retention profile id</param>
		[Get("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
		Task<CameraQualityRetentionProfile> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qualityRetentionProfileId")] string qualityRetentionProfileId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the quality retention profiles for this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/camera/qualityRetentionProfiles")]
		Task<List<CameraQualityRetentionProfile>> GetAllAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update an existing quality retention profile for this network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="qualityRetentionProfileId">The quality retention profile id</param>
		/// <param name="updateNetworkCameraQualityRetentionProfile">Body for updating quality retention profile</param>
		[Put("/networks/{networkId}/camera/qualityRetentionProfiles/{qualityRetentionProfileId}")]
		Task<CameraQualityAndRetentionSettings> UpdateAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("qualityRetentionProfileId")] string qualityRetentionProfileId,
			[Body] CameraQualityAndRetentionProfileUpdateRequest updateNetworkCameraQualityRetentionProfile,
			CancellationToken cancellationToken = default);
	}
}
