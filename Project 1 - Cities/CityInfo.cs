using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project1
{
    //CityInfo class
    //Purpose: City Class that will contain information from files inside program
    //Authors: Mark Medvedev, Justin Kuchmy, Francisco Garcia
    public class CityInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("city")]
        public string CityName { get; set; }
        [JsonPropertyName("city_ascii")]
        public string CityAscii { get; set; }
        [JsonPropertyName("population")]
        public string Population { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("admin_name")]
        public string Province { get; set; }
        [JsonPropertyName("capital")]
        public string Capital { get; set; }
        [JsonPropertyName("lat")]
        public string Latitude { get; set; }
        [JsonPropertyName("lng")]
        public string Longitude { get; set; }
                

        public CityInfo() { }
        public CityInfo(string city, string city_ascii, string lat, string lng, string country, string province, string capital, string population, string id)
        {
            this.CityName = city;
            this.Id = id;
            this.CityAscii = city_ascii;
            this.Latitude = lat;
            this.Longitude = lng;
            this.Population = population;
            this.Country = country;
            this.Capital = capital;
            this.Province = province;
        }

        public int GetId()
        {
            return Int32.Parse(Id);
        }

        public string GetProvince()
        {
            return Province;
        }

        public string GetPopulation()
        {
            return Population;
        }

        public string GetLocation()
        {
            return Latitude + "," + Longitude;
        }
    }
}