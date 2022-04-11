using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC_Practice_April10.Models
{
    public class WSBApiCall
    {
        public static async Task<WSBObject> GetWSBObject(string ticker)
        {
            var connection = await WSBClient.HttpClient.GetAsync($"/api/v1/apps/reddit");
            List<WSBObject> wsbObjects = await connection.Content.ReadAsAsync<List<WSBObject>>();

            WSBObject wsbObject = new WSBObject();

            for (int i = 0; i < wsbObjects.Count; i++)
            {
                if (wsbObjects[i].ticker.ToLower() == ticker.ToLower())
                {
                    wsbObject = wsbObjects[i];
                }
            }

            return wsbObject;
        }
    }
}
