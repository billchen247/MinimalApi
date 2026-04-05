using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using System.Text;
using System.Net;
using System.Text.Json;
using System.Net.Http.Headers;
using MinimalApi.ViewModels;


namespace MinimalApi.Tests;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Testing"); // 👈 MUST be here
    }
}
