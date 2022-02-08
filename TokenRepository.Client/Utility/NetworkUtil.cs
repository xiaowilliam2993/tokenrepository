using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TokenRepository.NetworkRequest.Core;
using TokenRepository.NetworkRequest.Models;

namespace TokenRepository.Client.Utility
{
    public static class NetworkUtil
    {
        public static T Get<T>(string url, IDictionary<string, string> headerParameters = null) where T : class
        {
            return GetList<T>(url, headerParameters)?.FirstOrDefault();
        }

        public static IEnumerable<T> GetList<T>(string url, IDictionary<string, string> headerParameters = null) where T : class
        {
            #region Parameters validate
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            #endregion

            _ = Activator.CreateInstance<List<T>>();
            var responseMessage = NetworkRequestWorker.Get(url, headerParameters);
            List<T> instance;
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.GetResultAsGeneric<ApiContext>();
                if (result.Status == ApiStatus.Success)
                {
                    var data = (JArray)result.Data;
                    if (data.Count > 0)
                    {
                        instance = JsonConvert.DeserializeObject<List<T>>(data.ToString());
                    }
                    else
                    {
                        throw new Exception("The query has no records.");
                    }
                }
                else
                {
                    throw new Exception(result.Message);
                }
            }
            else
            {
                throw new HttpRequestException(responseMessage.Content.ReadAsStringAsync().Result);
            }
            return instance;
        }

        public static ApiContext Post(string url, object body, IDictionary<string, string> headerParameters = null)
        {
            #region Parameters validate
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            #endregion

            return ResponseInvoke(NetworkRequestWorker.Post(url, body, headerParameters));
        }

        public static ApiContext Put(string url, object body, IDictionary<string, string> headerParameters = null)
        {
            #region Parameters validate
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            #endregion

            return ResponseInvoke(NetworkRequestWorker.Put(url, body, headerParameters));
        }

        public static ApiContext Delete(string url, object body, IDictionary<string, string> headerParameters = null)
        {
            #region Parameters validate
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            #endregion

            return ResponseInvoke(NetworkRequestWorker.Delete(url, body, headerParameters));
        }

        public static ApiContext ResponseInvoke(HttpResponseMessage responseMessage)
        {
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.GetResultAsGeneric<ApiContext>();
                if (result.Status == ApiStatus.Success)
                {
                    return result;
                }
                else
                {
                    throw new Exception(result.Message);
                }
            }
            else
            {
                throw new HttpRequestException(responseMessage.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
