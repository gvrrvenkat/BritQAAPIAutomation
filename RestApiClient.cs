using RestSharp;
using System;


namespace BritQAAPIAutomation
{
    public class RestApiClient : IApiClient
    {
        private readonly RestClient _client;

        public RestApiClient()
        {
            _client = new RestClient("https://api.restful-api.dev/");
        }

        public RestResponse GetObjects()
        {
            var request = new RestRequest("objects", Method.Get);
            var response = _client.Execute(request);
            // Log the response
            Console.WriteLine($"Response status: {response.StatusCode}");
            Console.WriteLine($"Response content: {response.Content}");
            return response;
        }

        public RestResponse GetObjectById(string id)
        {
            var request = new RestRequest($"objects/{id}", Method.Get);
            return _client.Execute(request);
        }

        public RestResponse CreateObject(string body)
        {
            var request = new RestRequest("objects", Method.Post);
            request.AddJsonBody(body);
            return _client.Execute(request);
        }

        public RestResponse UpdateObject(string id, string body)
        {
            var request = new RestRequest($"objects/{id}", Method.Put);
            request.AddJsonBody(body);
            return _client.Execute(request);
        }

        public RestResponse DeleteObject(string id)
        {
            var request = new RestRequest($"objects/{id}", Method.Delete);
            return _client.Execute(request);
        }
    }
}
