using System;
using System.Collections.Generic;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Project1
{
    class Program
    {
        private const string JSON_DATA = "../../../Data/Canadacities-JSON.json";
        private const string XML_DATA = "../../../Data/Canadacities-XML.xml";
        private const string CSV_DATA = "../../../Data/Canadacities.csv";
        static void Main(string[] args)
        {
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(XML_DATA);
        //    List<CityData> CityList = new List<CityData>(); //This is for the json data. 
        //    Dictionary<string, Object> dict = new Dictionary<string, object>(); //this is for the CSV data. 

        //    string data;
        //    if (ReadFile(JSON_DATA, out data))
        //    {
        //        try
        //        {
        //            Console.WriteLine("file loaded");
        //            CityList = ReadJsonFileToLib();
        //        }
        //        catch (IOException)
        //        {
        //            Console.WriteLine("Error: Cant open JSON file.");
        //        }
        //    }

        //    using (var reader = new StreamReader(CSV_DATA))
        //    {

        //        var line = reader.ReadLine();
        //        var values = line.Split(',');
        //        var propNames = new string[9];
        //        int i = 0;
        //        foreach (string str in values)
        //        {

        //            propNames[i] = str;
        //            i++;
        //        }

        //        while (!reader.EndOfStream)
        //        {
        //            int idx = 0;
        //            line = reader.ReadLine();
        //            values = line.Split(',');
        //            CityData obj = new CityData();
        //            foreach (var item in propNames)
        //            {

        //                Type type = obj.GetType();
        //                PropertyInfo prop = type.GetProperty(item.ToString());
        //                if (prop != null)
        //                {
        //                    if (propNames[idx] == "lat" || propNames[idx] == "lng")
        //                    {
        //                        var doubleVariable = double.Parse(values[idx]);
        //                        prop.SetValue(obj, doubleVariable, null);
        //                    }
        //                    else if (propNames[idx] == "population")
        //                    {
        //                        var intVariable = Int32.Parse(values[idx]);
        //                        prop.SetValue(obj, intVariable, null);
        //                    }
        //                    else if (propNames[idx] == "id")
        //                    {
        //                        var longVariable = Int64.Parse(values[idx]);
        //                        prop.SetValue(obj, longVariable, null);
        //                    }
        //                    else
        //                    {
        //                        prop.SetValue(obj, values[idx], null);
        //                    }
        //                    idx++;

        //                }
        //            }
        //            if (!dict.ContainsKey(values[0]))
        //                dict.Add(values[0], obj);
        //            else Console.WriteLine(values[0] + " Already Exists as a Key");
        //        }
        //        Console.WriteLine("Total cities added to Dictionary.." + dict.Count);
        //    }


        //    //printing out the data from the xml but not stored but we have the same
        //    //data stored already from the json and csv. 
        //    foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        //    {
        //        string ParentTagName = node.Name;
        //        Console.WriteLine($"{ParentTagName}");
        //        foreach (XmlNode node2 in node)
        //        {
        //            string TagName = node2.Name;
        //            string TagValue = node2.InnerText;
        //            Console.WriteLine($"\t{TagName}: {TagValue}\n");
        //        }
        //    }


        //    //foreach (CityData item in CityList)
        //    //{
        //    //    Console.WriteLine($"City: {item.city}");
        //    //    Console.WriteLine($"City_ascii:{item.city_ascii}");
        //    //    Console.WriteLine($"Lat: {item.lat}");
        //    //    Console.WriteLine($"Lng: {item.lng}");
        //    //    Console.WriteLine($"Country: {item.country}");
        //    //    Console.WriteLine($"Admin_name: {item.admin_name}");
        //    //    Console.WriteLine($"Capital: {item.capital}");
        //    //    Console.WriteLine($"Population: {item.population}");
        //    //    Console.WriteLine($"Id: {item.id}");
        //    //    Console.WriteLine("\n");
        //    //}


        //}

        //private static bool ReadFile(string path, out string json)
        //{
        //    try
        //    {
        //        // json = path;
        //        json = File.ReadAllText(path);
        //        return true;
        //    }
        //    catch
        //    {
        //        json = null;
        //        return false;
        //    }
        //}

        //private static void WriteLibToJsonFile(ref List<CityData> lib)
        //{
        //    string json = JsonConvert.SerializeObject(lib);
        //    File.WriteAllText(JSON_DATA, json); //where its writing it and what its writing
        //} //WriteLibToJsonFile

        //private static List<CityData> ReadJsonFileToLib()
        //{
        //    //returns a string to read all the data from the json file
        //    string json = File.ReadAllText(JSON_DATA);
        //    List<CityData> data = JsonConvert.DeserializeObject<List<CityData>>(json);
        //    return data;
        //}

        //public string GetPropertyName<T>(Expression<Func<T>> propertyLambda)
        //{
        //    var me = propertyLambda.Body as MemberExpression;

        //    if (me == null)
        //    {
        //        throw new ArgumentException("You must pass a lambda of the form: '() => Class.Property' or '() => object.Property'");
        //    }

        //    return me.Member.Name;
        }
    }
}
