/*
 * EasyBimehLanding.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using EasyBimehLanding.Standard.Http.Client;
using EasyBimehLanding.Standard.Http.Request;
using EasyBimehLanding.Standard.Http.Response;

namespace EasyBimehLanding.Tests.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}