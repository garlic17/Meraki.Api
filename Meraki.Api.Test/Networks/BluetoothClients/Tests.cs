﻿namespace Meraki.Api.Test.Networks.BluetoothClients;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetBluetoothClientsAsync_Succeeds()
	{
		var network = await GetFirstNetworkAsync()
			.ConfigureAwait(false);

		var result = await TestMerakiClient
			.Networks
			.BluetoothClients
			.GetNetworkBluetoothClientsAsync(network.Id)
			.ConfigureAwait(false);
		result.Should().BeOfType<List<BluetoothClient>>();
		result.Should().NotBeNull();
	}
}
