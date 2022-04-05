using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml;
using Microsoft.VisualBasic.FileIO;

namespace Project1
{
    //DataModeler class
    //Purpose: Parses through files to return data user desires
    //Authors: Mark Medvedev, Justin Kuchmy, Francisco Garcia
    public class DataModeler
    {
        public static List<CityInfo> Cities;
        public static Dictionary<string, List<CityInfo>> CityDictionary;

        // Delegate for the parsing methods
        public delegate void ParseDelegate(string file);

        //ParseXML
        //Purpose: Parses file of xml format into dictionary
        public static void ParseXML(string fileName)
        {
            if(CityDictionary != null)
            {
                CityDictionary = null;
                CityDictionary = new Dictionary<string, List<CityInfo>>();
                
            }
            else
            {
                CityDictionary = new Dictionary<string, List<CityInfo>>();
               
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            //converting XML into JSON
            string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc.FirstChild.NextSibling);
            json = json.Remove(0, 30);
            json = json.Remove(json.Length - 2);

            //Deserialize into a list of CityInfo, and then to a Dictionary
            List<CityInfo> items = JsonSerializer.Deserialize<List<CityInfo>>(json);
            foreach (CityInfo item in items)
            {
                if (!CityDictionary.ContainsKey(item.CityName))
                {
                    Cities = new List<CityInfo>();
                    Cities.Add(item);
                    CityDictionary.Add(item.CityName, Cities);
                }
                else
                {
                    CityDictionary[item.CityName].Add(item);
                }
                    
            }
           
        }

        //ParseJSON
        //Purpose: Parses file of JSON format into dictionary
        public static void ParseJSON(string fileName)
        {
            if (CityDictionary != null)
            {
                CityDictionary = null;
                CityDictionary = new Dictionary<string, List<CityInfo>>();
            }
            else
            {
                CityDictionary = new Dictionary<string, List<CityInfo>>();
            }
            using (StreamReader reader = new StreamReader(fileName))
            {
                string json = reader.ReadToEnd();
                //Deserialize JSON into List of CityInfo, and finally into a Dictionary
                List<CityInfo> items = JsonSerializer.Deserialize<List<CityInfo>>(json);
                foreach (CityInfo item in items)
                {
                    if (!item.CityName.Equals(""))
                    {
                        if (!CityDictionary.ContainsKey(item.CityName))
                        {
                            Cities = new List<CityInfo>();
                            Cities.Add(item);
                            CityDictionary.Add(item.CityName, Cities);
                        }
                        else
                        {
                            CityDictionary[item.CityName].Add(item);
                        }

                    }

                }
               
            }
            
        }

        //ParseCSV
        //Purpose: Parses file of CSV format into dictionary
        public static void ParseCSV(string fileName)
        {
            if (CityDictionary != null)
            {
                CityDictionary = null;
                CityDictionary = new Dictionary<string, List<CityInfo>>();
            }
            else
            {
                CityDictionary = new Dictionary<string, List<CityInfo>>();
            }
            TextFieldParser parser = new TextFieldParser(fileName);
            
                parser.CommentTokens = new string[] { "#" };
                parser.SetDelimiters(new string[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;

                //eat the first line
                parser.ReadLine();

                while (!parser.EndOfData)   
                {
                    string[] fields = parser.ReadFields();  //gets the whole line
                    string name = fields[0];                //City Name 
                    string ascii = fields[1];               //City Name ASCII 
                    string lat = fields[2];                 //Latitude 
                    string lon = fields[3];                 //Longitude 
                    string country = fields[4];             //Country 
                    string pr = fields[5];                  //Province 
                    string cap = fields[6];                 //Capital 
                    string pop = fields[7];                 //Population 
                    string id = fields[8];                  //CityID 
                    CityInfo city = new CityInfo(name, ascii, lat, lon, country, pr, cap, pop, id);
                if (CityDictionary.ContainsKey(name))
                {

                    CityDictionary[name].Add(city);
                }
                else
                {
                    Cities = new List<CityInfo>();
                    Cities.Add(city);
                    CityDictionary.Add(name, Cities);
                }
                    
                }
        }

        //ParseFile
        //Purpose: using this function to easily get to parser function whatever file user needs(facade pattern)
        public static Dictionary<string, List<CityInfo>> ParseFile(string fileName, string fileType)
        {
            //using delegate to determine what parse it is going to be used
            ParseDelegate d1;

            switch (fileType)
            {
                case "XML":
                    d1 = ParseXML;
                    d1(fileName);
                    break;
                case "JSON":
                    d1 = ParseJSON;
                    d1(fileName);
                    break;
                case "CSV":
                    d1 = ParseCSV;
                    d1(fileName);
                    break;
                default:
                    Console.WriteLine("Type not found. Please enter XML, JSON or CSV.");
                    break;
            }

            return CityDictionary;
        }


    }
}
