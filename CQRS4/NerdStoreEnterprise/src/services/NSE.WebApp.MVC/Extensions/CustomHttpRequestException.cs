using System;
using System.Net;

namespace NSE.WebApp.MVC.Extensions
{
    public class CustomHttpRequestException : System.Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpRequestException() { }

        public CustomHttpRequestException(string message, System.Exception innerException)
            : base(message, innerException) { }

        public CustomHttpRequestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}