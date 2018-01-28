using System;
using System.IO;
using System.Net;

namespace restClient
{
    class RestClient
    {
        public string endPoint { get; set; }
        public string body { get; set; }
        public string httpMethod { get; set; }

        public RestClient(string endPoint, string httpMethod)
        {
            this.endPoint = endPoint;
            this.httpMethod = httpMethod;
            this.body = string.Empty;
        }

        public Tuple<string, string> makeRequest()
        {
            string strResponseValue = string.Empty;
            Tuple<string, string> result = null;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(endPoint);

            request.Method = httpMethod;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                //if (response.StatusCode != HttpStatusCode.OK)
                //    throw new ApplicationException("error code: " + response.StatusCode);

                // Process the response stream
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                        using (StreamReader reader = new StreamReader(responseStream))
                            strResponseValue = reader.ReadToEnd();
                }

                result = new Tuple<string, string>(strResponseValue, response.StatusCode.ToString());
            }

            return result;
        }
    }
}
