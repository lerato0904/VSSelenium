using RestSharp;
using System.Dynamic;
using System.Net;

namespace APITesting
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            RestClient client = new RestClient("https://automationexercise.com/api/productsList");
            RestRequest request = new RestRequest("", Method.Get);

            RestResponse response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            Console.WriteLine(response.Content);
        }
    }
}