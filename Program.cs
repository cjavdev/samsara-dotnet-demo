using System;
using Samsara.Net;
using Samsara.Net.Addresses;


var key = Environment.GetEnvironmentVariable("SAMSARA_KEY");
var client = new SamsaraClient(token: key);

// Works
var addressPage = await client.Addresses.ListAsync(new AddressesListRequest
{
  Limit = 50
});

await foreach (var address in addressPage)
{
  Console.WriteLine(address.FormattedAddress);
}