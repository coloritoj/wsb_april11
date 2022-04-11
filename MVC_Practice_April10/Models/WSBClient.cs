using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC_Practice_April10.Models
{
    public class WSBClient
    {
        private static HttpClient _realClient;

        public static HttpClient HttpClient
        {
            get
            {
                if (_realClient == null)
                {
                    _realClient = new System.Net.Http.HttpClient();
                    _realClient.BaseAddress = new Uri("https://dashboard.nbshare.io/");
                }

                return _realClient;
            }
        }
    }
}
