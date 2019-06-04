using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace StarWarsAPITest.Models
{
    public class StarWarsDAL
    {
        public static string GetData(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0)0 Gecko/20100101 Firefox/47.0";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if(response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader data = new StreamReader(response.GetResponseStream());

                return data.ReadToEnd();
            }

            return null;
        }

        public static Person GetPerson(int i)
        {
            return new Person(GetData($"https://swapi.co/api/people/{i}/"));
        }

        public static Planet GetPlanet(int i)
        {
            return new Planet(GetData($"https://swapi.co/api/planets/{i}/"));
        }
    }
}