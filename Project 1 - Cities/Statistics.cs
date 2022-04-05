using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using System.Diagnostics;

namespace Project1
{
    //Statistics class
    //Purpose: Collects the data and processes it at user's requests
    //Authors: Mark Medvedev, Justin Kuchmy, Francisco Garcia
    public class Statistics
    {
        public Dictionary<string, List<CityInfo>> CityCatalogue; // dictionary to store all data from files

        public Statistics(string filename, string filetype)// constructor generates data using data modeler parser
        {
            CityCatalogue = DataModeler.ParseFile(filename, filetype);
            // doing something with data modeler
        }

        //DisplayCityInformation
        //Purpose: displays city's information using city's name
        public string DisplayCityInformation(string cityName)
        {
            string strCityInfo = "";
            List<CityInfo> info;
            if (CityCatalogue.TryGetValue(cityName, out info))
            {
                foreach(CityInfo c in info)
                {
                    strCityInfo +=
                   $"City {cityName}:\n" +
                   $"\tPopulation - {c.Population}\n" +
                   $"\tProvince - {c.Province}\n" +
                   $"\tLatitude - {c.Latitude} Longitude - {c.Longitude}\n" +
                   $"\tCountry - {c.Country}\n" +
                   $"\tCapital - {c.Capital}\n";
                }
               
            }
            else
            {
                strCityInfo += "Error! No such City was found!";
            }
            return strCityInfo;
        }
        //DisplayLargestPopulationCity
        //Displays city with largest population in the province
        public string DisplayLargestPopulationCity(string province)
        {
            string cityName = "No city was found!";
            int population = 0;
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue) //going through every city
            {
                foreach(CityInfo c in info.Value)
                {
                    if (c.Province == province) // if we found a province matching our request, we check if we just started looking or not
                    {
                        if (cityName == "No city was found!") // if not yet found, we simply setup largest city
                        {
                            cityName = c.CityName;
                            population = Int32.Parse(c.Population);
                        }
                        else // else we check to population size
                        {
                            int newPopulation = Int32.Parse(c.Population);
                            if (population < newPopulation) // if our current population is smaller, we change to bigger one
                            {
                                cityName = c.CityName;
                                population = newPopulation;
                            }
                        }
                    }

                }
                
            }
            return cityName;
        }


        //DisplaySmallestPopulationCity
        //Displays city with smallest population in the province
        public string DisplaySmallestPopulationCity(string province) // same as finding largest population but different check
        {
            string cityName="";
            int population = 0;
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach (CityInfo c in info.Value)
                {
                    if (c.Province == province)
                    {
                        if (cityName.Equals(""))
                        {
                            cityName = c.CityName;
                            population = Int32.Parse(c.Population);
                        }
                        else
                        {
                            int newPopulation = Int32.Parse(c.Population);
                            if (population > newPopulation) // we now check if current population is smaller than found one
                            {
                                cityName = c.CityName;
                                population = newPopulation;
                            }
                        }
                    }
                }
                    
            }
            return cityName;
        }

        //CompareCitiesPopluation
        //Purpose: shows the city's comparison with largest population
        public string CompareCitiesPopluation(string name1, string province1, string name2, string province2)
        {
            //string cityName = "";
            List<CityInfo> cityL1, cityL2;
            CityInfo city1 = new CityInfo(), city2 = new CityInfo();
            if (CityCatalogue.TryGetValue(name1, out cityL1) && CityCatalogue.TryGetValue(name2, out cityL2))
            {
                foreach(CityInfo c in cityL1)
                {
                    if (c.GetProvince() == province1)
                    {
                        city1 = c;
                    }
                }
                foreach (CityInfo c in cityL2)
                {
                    if (c.GetProvince() == province2)
                    {
                        city2 = c;
                    }
                }

                return (Int32.Parse(city1.Population) > Int32.Parse(city2.Population)) ? name1 : name2;
            }
            else
            {
                return "Error, one of the cities were not found!";
            }
        }
        //ShowCityOnMap
        //Purpose: Using default browser to find a location using google map
        public void ShowCityOnMap(string name, string province)
        {
            CityInfo city;
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    if (c.CityName == name && c.Province == province)
                    {
                        string url = "https://www.google.com/maps/place/";
                        url += c.Latitude + " " + c.Longitude;
                        System.Diagnostics.Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                        break;
                    }
                }
               
                   
            }

        }
        //CalculateDistanceBetweenCities
        //Purpose: Calculate distance between cities using their geographical coordinates
        //Sidenote: Instead of using browser or APIs, it was decided to create math formula using Math class, the formula in question is Spherical Law of Cosines
        public string CalculateDistanceBetweenCities(string name1, string province1, string name2, string province2)
        {
            List<CityInfo> cityL1, cityL2;
            CityInfo city1 = new CityInfo();
            CityInfo city2 = new CityInfo();
            if (CityCatalogue.TryGetValue(name1, out cityL1) && CityCatalogue.TryGetValue(name2, out cityL2))
            { 
                foreach(CityInfo c in cityL1)
                {
                    if (c.GetProvince() == province1)
                    {
                        city1 = c;
                    }
                }
                foreach (CityInfo c in cityL2)
                {
                   if( c.GetProvince() == province2)
                    {
                        city2 = c;
                    }
                }
                // get distance using Spherical Law of Cosines
                //parse data to doubles
                double lat1 = Double.Parse(city1.Latitude), lat2 = Double.Parse(city2.Latitude);
                double lon1 = Double.Parse(city1.Longitude), lon2 = Double.Parse(city2.Longitude);
                //get values
                double R = 6371e3; // constant
                double angle1 = lat1 * Math.PI / 180.0, angle2 = lat2 * Math.PI / 180.0; // angles
                double delta = (lon2 - lon1) * Math.PI / 180.0; // and delta lambda between them

                double distance = Math.Acos(Math.Sin(angle1) * Math.Sin(angle2) + Math.Cos(angle1) * Math.Cos(angle2) * Math.Cos(delta)) * R;
                return $"{Math.Round(distance / 1000, 2)} KM";
            }
            else
            {
                return "Error, one of the cities were not found!";
            }
        }
        //DisplayProvincePopulation
        //Purpose: Gets all cities of the province to get its total population
        public int DisplayProvincePopulation(string province)
        {
            int totalProvincialPopulation = 0;
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    if (c.Province == province)
                        totalProvincialPopulation += Int32.Parse(c.Population);
                }
                
            }
            return totalProvincialPopulation;
        }
        //DisplayProvinceCities
        //Purpose: Gets all cities of the province
        public List<string> DisplayProvinceCities(string province)
        {
            List<string> citiesList = new List<string>();
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    if (c.Province == province)
                    {
                        citiesList.Add(c.CityName);
                    }
                }
                
            }
            return citiesList;
        }
        //RankProvincesByPopulation
        //Purpose: Sorts provinces using each total population
        public string RankProvincesByPopulation()
        {
            string result = "";
            List<KeyValuePair<string, int>> newList = new List<KeyValuePair<string, int>>();
            List<string> provinces = new List<string>();
            SortedList<string, int> populationsPerProvince = new SortedList<string, int>();
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    if (!provinces.Contains(c.Province))
                    {
                        provinces.Add(c.Province);
                    }
                }
              
            }

            foreach (string province in provinces)
            {
                populationsPerProvince.Add(province, DisplayProvincePopulation(province));
            }



            foreach (var i in populationsPerProvince)
            {
                var item = new KeyValuePair<string, int>(i.Key, i.Value);
                newList.Add(item);
            }

            newList.Sort(new FuncComparer<KeyValuePair<string, int>>((a, b) => a.Value.CompareTo(b.Value)));
            int counter = 1;

            foreach (var item in newList)
            {
                result += $"{counter++}. {item.Key} \n    Population: {item.Value}\n";
            }

            return result;
        }
        //RankProvincesByCities
        //Purpose: Sorts provinces using each amount of cities
        public string RankProvincesByCities()
        {
            string result = "";

            List<KeyValuePair<string, int>> newList = new List<KeyValuePair<string, int>>();
            SortedList<string, int> RankedProvinces = new SortedList<string, int>();

            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    string province = c.Province;
                    string city = info.Key;
                    if (RankedProvinces.ContainsKey(province))
                    {
                        RankedProvinces[province]++;
                    }
                    else RankedProvinces.Add(province, 1);

                   

                }
               
            }
            foreach (var i in RankedProvinces)
            {
                var item = new KeyValuePair<string, int>(i.Key, i.Value);
                newList.Add(item);
            }
            newList.Sort(new FuncComparer<KeyValuePair<string, int>>((a, b) => a.Value.CompareTo(b.Value)));
            int counter = 1;
            foreach (var item in newList)
            {
                result += $"{counter++}. {item.Key} \n    Number Of Cities: {item.Value}\n";
            }

            return result;
        }
        //GetCapital
        //Purpose: Gets capital of the province
        public string GetCapital(string province)
        {
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    if (c.Province == province && c.Capital != null)
                    {
                        return $"{c.CityName} {c.Latitude} , {c.Longitude}";
                    }
                }
                
            }
            return "Error, province was not found!";
        }
        //GetPopulation
        //Purpose: Gets population of certain city in certain province
        public int GetPopulation(string cityname, string province)
        {
            
            foreach (KeyValuePair<string, List<CityInfo>> info in CityCatalogue)
            {
                foreach(CityInfo c in info.Value)
                {
                    if (info.Key.Equals(cityname) && c.GetProvince().Equals(province))
                    {
                        return Int32.Parse(c.GetPopulation());
                    }
                }
                
            }

                return 0;
        }


    }
}
