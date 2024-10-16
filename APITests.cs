using NUnit.Framework;
using RestSharp;
using System;

namespace BritQAAPIAutomation
{
    public class Tests
    {
        private IApiClient _apiClient;
        private RestResponse _response;
        [SetUp]
        public void Setup()
        {
            _apiClient = new RestApiClient();
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("GET OBJECT");
            _response = _apiClient.GetObjects();
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("GET OBJECT BY ID");
            _response = _apiClient.GetObjectById("3");
            Console.WriteLine("Status Code: " + _response.StatusCode);
            Console.WriteLine("Response Content: " + _response.Content);
            foreach (var header in _response.Headers)
            {
                Console.WriteLine($"Header: {header.Name} - Value: {header.Value}");
            }
        }

        [Test]
        public void Test3()
        {
            Console.WriteLine("CREATE AN OBJECT");

            // JSON body as string
            var jsonBody = @"
            {
               ""name"": ""Apple MacBook Pro 16"",
               ""data"": {
                  ""year"": 2019,
                  ""price"": 1849.99,
                  ""CPU model"": ""Intel Core i9"",
                  ""Hard disk size"": ""1 TB""
               }
            }";
            _response = _apiClient.CreateObject(jsonBody);
            Console.WriteLine("Status Code: " + _response.StatusCode);
            Console.WriteLine("Response Content: " + _response.Content);
        }

        [Test]
        public void Test4()
        {
            Console.WriteLine("UPDATE AN OBJECT");

            // JSON body as string 
            var jsonBody = @"
         {
         ""name"": ""Apple MacBook Pro 16"",
         ""data"": {
          ""year"": 2019,
          ""price"": 2049.99,
          ""CPU model"": ""Intel Core i9"",
          ""Hard disk size"": ""1 TB"",
          ""color"": ""silver""
            }
         }";
            string objectId = "7";
            _response = _apiClient.UpdateObject(objectId, jsonBody);
            Console.WriteLine("Status Code: " + _response.StatusCode);
            Console.WriteLine("Response Content: " + _response.Content);
        }
    }
}