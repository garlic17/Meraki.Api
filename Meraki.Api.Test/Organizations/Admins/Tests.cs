﻿namespace Meraki.Api.Test.Organizations.Admins;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAll_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Admins
			.GetOrganizationAdminsAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<Admin>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		var dateTime = result[0].LastActive;
		_ = dateTime.Should().NotBe(DateTime.MinValue);
	}
}
