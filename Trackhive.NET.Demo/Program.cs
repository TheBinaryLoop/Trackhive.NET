// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using Trackhive.NET;

var client = new TrackhiveClient("YOUR_API_TOKEN_HERE");
foreach (var courier in client.GetCouriersAsync().Result.Where(x => string.IsNullOrEmpty(x.Logo)))
{
    Console.WriteLine($"{courier.Slug} - {courier.Title}");
}