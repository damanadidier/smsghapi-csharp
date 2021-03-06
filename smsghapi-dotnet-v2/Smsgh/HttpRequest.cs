﻿namespace smsghapi_dotnet_v2.Smsgh
{
    public abstract class HttpRequest
    {
        protected static string UrlEncoded = "application/x-www-form-urlencoded;charset=UTF-8";

        protected HttpRequest(string path, ParameterMap parameters)
        {
            if (!path.IsEmpty()) {
                Path = path;
            }

            if (parameters != null) {
                string queryString = parameters.UrlEncode();
                Path += "?" + queryString;
            }
        }

        public string Path { set; get; } // avoid null in URL
        public string HttpMethod { set; get; }
        public string ContentType { set; get; }
        public byte[] Content { set; get; }
    }
}