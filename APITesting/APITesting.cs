using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace APITesting
{
    public class Tests
    {
        [Test]
        public void GivenValidEnpoint_WhenSendingAPostRequest_ThenSuccessStatusIsReturned()
        {
            //Arrange

            RestClient client = new RestClient("https://automationexercise.com/api/productsList");
            RestRequest request = new RestRequest("", Method.Get);
            
            //Act

            RestResponse response = client.Execute(request);

            //Assert 

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GivenAPostRequest_WhenSendingAPostToGetProductList_RequestNotSupportedResponseIsSentBack()
        {
            // Arrange

            RestClient client = new RestClient("https://automationexercise.com/api/productsList");
            RestRequest request = new RestRequest("", Method.Post);

            //Act

            RestResponse response = client.Execute(request);

            var responseContent = JsonConvert.DeserializeObject<APIResponse>(response.Content);

            //Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(responseContent, Is.Not.Null);
            Assert.That(responseContent.message, Is.EqualTo("This request method is not supported."));
        }
    }
}