using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1;

namespace GUI
{
    //Form1 class
    //Purpose: GUI Form that utilizes Statistics to play with data
    //Authors: Mark Medvedev, Justin Kuchmy, Francisco Garcia
    public partial class Form1 : Form
    {
        public Statistics myStats;
        public Form1()
        {
            InitializeComponent();
        }
        
        //Parse CSV button
        private void button1_Click(object sender, EventArgs e)
        {
            myStats = new Statistics("./Data/Canadacities.csv", "CSV");
            LoadProvinces();
            MessageBox.Show("CSV File Loaded");
        }

   

        //Parse JSON button
        private void button2_Click(object sender, EventArgs e)
        {
            myStats = new Statistics("./Data/Canadacities-JSON.json", "JSON");
            LoadProvinces();
            MessageBox.Show("JSON File Loaded");
        }

        //Parse XML button
        private void button3_Click(object sender, EventArgs e)
        {

                myStats = new Statistics("./Data/Canadacities-XML.xml", "XML");
                LoadProvinces();
                MessageBox.Show("XML File Loaded");

        }
            

        //Event handler for the province combo box in the general input groupbox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            provinceNameDisplay.Text = provinceBox.Text;
            provincePopulationDisplay.Text = myStats.DisplayProvincePopulation(provinceBox.Text).ToString();
            provinceCapitalDisplay.Text = myStats.GetCapital(provinceBox.Text);
            mostPopulatedDisplay.Text = myStats.DisplayLargestPopulationCity(provinceBox.Text);
            leastPopulatedDisplay.Text = myStats.DisplaySmallestPopulationCity(provinceBox.Text);
            cityBox.Items.Clear();
            cityBox.Text = "";
            cityNameDisplay.Text = "";
            cityPopulationDisplay.Text = "";
            locationDisplay.Text = "";
            List<string> myCities; ;
            if (myStats != null)
            {
                myCities = myStats.DisplayProvinceCities(provinceBox.Text);
                myCities.Sort();

                foreach(string s in myCities)
                {
                    cityBox.Items.Add(s);
                }
            }
           
        }

        //Method to load provinces in all the provinces combo box
        private  void LoadProvinces()
        {
             string[] provinces = { "Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland and Labrador", "Northwest Territories",
                                    "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island","Québec","Saskatchewan", "Yukon"};

            provinceBox.Items.Clear();
            provinceComboDist1.Items.Clear();
            provinceComboDist2.Items.Clear();
            provinceComboPop1.Items.Clear();
            provinceComboPop2.Items.Clear();

            for(int i = 0; i < provinces.Length; ++i)
            {
                provinceBox.Items.Add(provinces[i]);
                provinceComboDist1.Items.Add(provinces[i]);
                provinceComboDist2.Items.Add(provinces[i]);
                provinceComboPop1.Items.Add(provinces[i]);
                provinceComboPop2.Items.Add(provinces[i]);
            }

           
        }


        //Event handler for when the combo box for city is changed in the general input groupbox
        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityNameDisplay.Text = cityBox.Text;
            cityPopulationDisplay.Text = myStats.GetPopulation(cityBox.Text,provinceBox.Text).ToString();

            foreach(CityInfo c in myStats.CityCatalogue[cityBox.Text])
            {
                if (c.GetProvince() == provinceBox.Text)
                {
                    locationDisplay.Text = c.GetLocation();
                }
            }
            
        }


        //Event handler for when the combo box for province 1 in the population comparison  groupbox changes
        private void provinceComboPop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboPop1.Items.Clear();
            cityComboPop1.Text = "";
            List<string> myCities;
            if (myStats != null)
            {
                myCities = myStats.DisplayProvinceCities(provinceComboPop1.Text);
                myCities.Sort();

                

                foreach (string s in myCities)
                {
                    cityComboPop1.Items.Add(s);
                }
            }
        }

        //Event handler for when the combo box for province 2 in the population comparison  groupbox changes
        private void provinceComboPop2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboPop2.Items.Clear();
            cityComboPop2.Text = "";
            List<string> myCities;
            if (myStats != null)
            {
                myCities = myStats.DisplayProvinceCities(provinceComboPop2.Text);

                myCities.Sort();

                foreach (string s in myCities)
                {
                    cityComboPop2.Items.Add(s);
                }
            }
        }

        //Event handler for when the combo box for province 1 in the distance calculation groupbox changes
        private void provinceComboDist1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboDist1.Items.Clear();
            cityComboDist1.Text = "";
            List<string> myCities;
            if (myStats != null)
            {
                 myCities = myStats.DisplayProvinceCities(provinceComboDist1.Text);

                myCities.Sort();

                foreach (string s in myCities)
                {
                    cityComboDist1.Items.Add(s);
                }
            }
        }

        //Event handler for when the combo box for province 2 in the distance calculation groupbox changes
        private void provinceComboDist2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboDist2.Items.Clear();
            cityComboDist2.Text = "";
            List<string> myCities;
            if (myStats != null)
            {
                myCities = myStats.DisplayProvinceCities(provinceComboDist2.Text);

                myCities.Sort();

                foreach (string s in myCities)
                {
                    cityComboDist2.Items.Add(s);
                }
            }
        }

        //compute city population button
        private void compareBtn_Click(object sender, EventArgs e)
        {
            if (myStats != null)
            {
                citynamePopLabel.Text = myStats.CompareCitiesPopluation(cityComboPop1.Text, provinceComboPop1.Text, cityComboPop2.Text, provinceComboPop2.Text);
                string province;
                if (citynamePopLabel.Text.Equals(cityComboPop1.Text))
                {
                    province = provinceComboPop1.Text;
                }
                else
                {
                    province = provinceComboPop2.Text;
                }
                popComparerLabel.Text = myStats.GetPopulation(citynamePopLabel.Text, province).ToString();
            } 
            else
                MessageBox.Show("Please parse a file first.");
        }

        //Calculate distance between cities button
        private void calcDistanceBtn_Click(object sender, EventArgs e)
        {
            if (myStats != null)
                totalDistLabel.Text = myStats.CalculateDistanceBetweenCities(cityComboDist1.Text, provinceComboDist1.Text,cityComboDist2.Text,provinceComboDist2.Text);
            else
                MessageBox.Show("Please parse a file first.");

        }

        //Clear button
        private void button4_Click(object sender, EventArgs e)
        {
            cityBox.Text = "";
            cityNameDisplay.Text = "";
            cityPopulationDisplay.Text = "";
            locationDisplay.Text = "";
            popComparerLabel.Text = "";
            totalDistLabel.Text = "";
            provinceComboDist1.Text = "";
            provinceComboDist2.Text = "";
            provinceComboPop1.Text = "";
            provinceComboPop2.Text = "";
            cityComboDist1.Text = "";
            cityComboDist2.Text = "";
            cityComboPop1.Text = "";
            cityComboPop2.Text = "";
            provByCityLBox.Items.Clear();
            provinceBox.Text = "";
            provinceNameDisplay.Text = "";
            provincePopulationDisplay.Text = "";
            provinceCapitalDisplay.Text = "";
            mostPopulatedDisplay.Text = "";
            leastPopulatedDisplay.Text = "";

        }

       
        //Rank provinces by cities
        private void button5_Click(object sender, EventArgs e)
        {
            if (myStats == null)
            {
                MessageBox.Show("Please parse a file first.");
            }
            else
            {
                provincesRankingLabel.Text = "Provinces Ranking\n        By Cities";
                provByCityLBox.Items.Clear();
                string ranking = myStats.RankProvincesByCities();
                List<string> mylist = new List<string>();
                mylist = ranking.Split('\n').ToList();

                foreach (string s in mylist)
                {
                    provByCityLBox.Items.Add(s);
                }
            }

        }

        
        //ranking provinces by population
        private void button6_Click(object sender, EventArgs e)
        {
            if (myStats == null)
            {
                MessageBox.Show("Please parse a file first.");
            }
            else
            {
                provincesRankingLabel.Text = "Provinces Ranking\n    By Population";
                provByCityLBox.Items.Clear();
                string ranking = myStats.RankProvincesByPopulation();
                List<string> mylist = new List<string>();
                mylist = ranking.Split('\n').ToList();

                foreach (string s in mylist)
                {
                    provByCityLBox.Items.Add(s);
                }
            }
        }

        //Show in map button
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (myStats != null)
                myStats.ShowCityOnMap(cityNameDisplay.Text,provinceBox.Text);
            else
                MessageBox.Show("Please parse a file first."); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
