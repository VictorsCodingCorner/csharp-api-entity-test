using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Text;

namespace workshop.tests;

public partial class Tests
{

    [Test]
    public async Task PatientEndpointStatus()
    {
        // Arrange
        var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
        var client = factory.CreateClient();

        // Act
        var response = await client.GetAsync("http://localhost:5045/surgery/patients");

        // Assert
        Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);


        // Act
        var response1 = await client.GetAsync("http://localhost:5045/surgery/patients?id=201&name=Test123");

        // Assert
        Assert.IsTrue(response1.StatusCode == System.Net.HttpStatusCode.OK);
    }
}