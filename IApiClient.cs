using RestSharp;

namespace BritQAAPIAutomation
{
    public interface IApiClient
    {
        RestResponse GetObjects();
        RestResponse GetObjectById(string id);
        RestResponse CreateObject(string body);
        RestResponse UpdateObject(string id, string body);
        RestResponse DeleteObject(string id);
    }
}
