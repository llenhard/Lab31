using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsAPITest.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string HomePlanet { get; set; }

        public Person(string apiText)
        {
            JObject data = JObject.Parse(apiText);
            Name = (string)data["name"];
            Species = "Excluded because we dont have GetSpecies and im lazy";
            Gender = (string)data["gender"];
            HomePlanet = (string)JObject.Parse(StarWarsDAL.GetData((string)data["homeworld"]))["name"];//aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        }
    }
}